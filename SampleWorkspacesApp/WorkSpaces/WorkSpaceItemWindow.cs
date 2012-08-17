using System;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SampleWorkspacesApp.WorkSpaces
{
    public partial class WorkSpaceItemWindow : WorkItemDockContent
    {
        private const string MoveWorkSpaceItemContextMenuIdentifer = "MoveWorkSpaceItemContextMenu";

        private class ContextMenuItemTag
        {
            public string MenuIdentifer { get; set; }
            public IWorkSpaceShell Shell { get; set; }

            public ContextMenuItemTag()
            {
                MenuIdentifer = string.Empty;
                Shell = null;
            }
        }

        public WorkSpaceItemWindow() :
            base(EWorkItemContentType.WorkspaceItem)
        {
            InitializeComponent();

            this.contextMenuStrip.Items.Add("Menu option 1");
            this.contextMenuStrip.Items.Add("Menu option 2");

            //optional
            this.DockStateChanged += new EventHandler(OnDockStateChanged);
        }

        private void OnDockStateChanged(object sender, EventArgs e)
        {
        }

        private void OnPathMoveWorkItemContextMenu()
        {
            if (this.ContextMenuStrip.Items.Count > 0 && (WorkspacesDock.WorkSpaceManager().WorkSpacesCount() > 1))
            {
                ToolStripItem separator = this.ContextMenuStrip.Items.Add("-");
                separator.Tag = new ContextMenuItemTag {MenuIdentifer = MoveWorkSpaceItemContextMenuIdentifer, Shell = null};
            }

            ToolStripMenuItem moveMenu = new ToolStripMenuItem("Move to...")
                                             {
                                                 Tag = new ContextMenuItemTag
                                                           {
                                                               MenuIdentifer = MoveWorkSpaceItemContextMenuIdentifer,
                                                               Shell = this.ParentWorkSpaceShell
                                                           }
                                             };

            this.ContextMenuStrip.Items.Add(moveMenu);

            int currentWorkSpaceId = ((WorkSpaceShell)ParentWorkSpaceShell).WorkSpaceId();
            foreach (WorkSpaceShell workSpaceShell in WorkspacesDock.WorkSpaceManager())
            {
                if (currentWorkSpaceId == workSpaceShell.WorkSpaceId())
                    continue;

                ContextMenuItemTag menuTag = new ContextMenuItemTag
                                                 {
                                                     MenuIdentifer = MoveWorkSpaceItemContextMenuIdentifer,
                                                     Shell = workSpaceShell
                                                 };

                ToolStripItem item = new ToolStripMenuItem(workSpaceShell.WorkSpaceName, null, OnClick_MoveWorkSpaceItem) { Tag = menuTag };
                moveMenu.DropDownItems.Add(item);
            }
        }

        private void OnUnPathMoveWorkItemContextMenu()
        {
            for (int i = 0; i < this.ContextMenuStrip.Items.Count; ++i)
            {
                ToolStripItem item = this.ContextMenuStrip.Items[i];
                ContextMenuItemTag itemTag = (ContextMenuItemTag)item.Tag;
                if (!ReferenceEquals(itemTag, null) && itemTag.MenuIdentifer == MoveWorkSpaceItemContextMenuIdentifer)
                {
                    this.ContextMenuStrip.Items.RemoveAt(i--);
                }
            }
        }

        private void OnClick_MoveWorkSpaceItem(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem) sender;
            ContextMenuItemTag itemTag = (ContextMenuItemTag)item.Tag;

            if (ReferenceEquals(itemTag.Shell, null))
                return;

            itemTag.Shell.MoveTo(this);

            this.ParentWorkSpaceShell = itemTag.Shell;
            this.DockHandler.DockState = DockState.Float;

            OnUnPathMoveWorkItemContextMenu();
            OnPathMoveWorkItemContextMenu();
        }
        
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (this.DockHandler.VisibleState == DockState.Float)
            {
                if (ReferenceEquals(this.ContextMenuStrip, null))
                    return;

                bool isMoveMenuEnabled = false;
                for (int i = 0; i < this.ContextMenuStrip.Items.Count; ++i)
                {
                    ToolStripItem item = this.ContextMenuStrip.Items[i];
                    ContextMenuItemTag itemTag = (ContextMenuItemTag)item.Tag;
                    if (!ReferenceEquals(itemTag, null) && itemTag.MenuIdentifer == MoveWorkSpaceItemContextMenuIdentifer)
                    {
                        isMoveMenuEnabled = true;
                    }
                }
                
                if (!isMoveMenuEnabled)
                    OnPathMoveWorkItemContextMenu();
            }
            else if (this.DockHandler.VisibleState != DockState.Unknown)
            {
                if (ReferenceEquals(this.ContextMenuStrip, null))
                    return;

                for (int i = 0; i < this.ContextMenuStrip.Items.Count; ++i)
                {
                    ToolStripItem item = this.ContextMenuStrip.Items[i];
                    ContextMenuItemTag itemTag = (ContextMenuItemTag)item.Tag;
                    if (!ReferenceEquals(itemTag, null) && itemTag.MenuIdentifer == MoveWorkSpaceItemContextMenuIdentifer)
                    {
                        this.ContextMenuStrip.Items.RemoveAt(i--);
                    }
                }
            }
        }

        #region Save and Restore Configuration
        public override void Save(System.Xml.XmlTextWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(typeof(WorkSpaceItemWindow).Name);
            xmlWriter.WriteEndElement();
        }
        public override void Init(System.Xml.XmlTextReader xmlReader)
        {
            //PersistorExt.MoveToNextElement(xmlReader);
        }
        #endregion Save and Restore Configuration
    }
}
