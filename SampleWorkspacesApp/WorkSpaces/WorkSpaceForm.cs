using System.Windows.Forms;
using System.Xml;
using WeifenLuo.WinFormsUI.Docking;

namespace SampleWorkspacesApp.WorkSpaces
{
    public sealed partial class WorkSpaceForm : Form
    {
        private readonly DockPanelExt.DeserializeDockContentDelegate m_DeserializeItemContent;

        public DockPanel WorkSpaceDockPanel()
        {
            return m_DockPanel;
        }

        public WorkSpaceForm(string tabText)
        {
            InitializeComponent();

            this.Text = tabText;

            m_DeserializeItemContent = DeserializeItemContent;
        }

        public void AddItem(WorkItemDockContent workItem)
        {
            workItem.Show(m_DockPanel);
        }

        public void RemoveItem(WorkItemDockContent workItem)
        {
            workItem.DockHandler.Close();
        }

        public void MoveTo(WorkItemDockContent workItem, WorkSpaceShell targetWorkSpace)
        {
            DockPanel panel = ((WorkSpaceForm) targetWorkSpace.WorkForm()).WorkSpaceDockPanel();
           
            WinAPI.Rect windowRect;
            if (!ReferenceEquals(workItem.ParentForm, null))
            {
                WinAPI.NativeMethods.GetWindowRect(workItem.ParentForm.Handle, out windowRect);
            }
            else
            {
                WinAPI.NativeMethods.GetWindowRect(workItem.Handle, out windowRect);
            }

            workItem.Show(panel, windowRect);
        }

        #region Save and Restore Workspaces Items
        public void SaveAllItems(XmlTextWriter xmlWriter)
        {
            m_DockPanel.Save(xmlWriter);
        }

        public void RestoreAllItems(XmlTextReader xmlReader)
        {
            PersistorExt.MoveToNextElement(xmlReader);
            PersistorExt.RestoreDockPanel(m_DockPanel, xmlReader, m_DeserializeItemContent);
        }

        private IDockContent DeserializeItemContent(string persistString, XmlTextReader xmlTextReader)
        {
            if (persistString.Equals(typeof(WorkSpaceItemWindow).Name))
                return RestoreWorkSpaceItem(xmlTextReader);
            
            return null;
        }

        private IDockContent RestoreWorkSpaceItem(XmlTextReader xmlTextReader)
        {
            var itemWindow = new WorkSpaceItemWindow();
            itemWindow.Init(xmlTextReader);

            return itemWindow;
        }

        #endregion Save and Restore Workspaces Items
    }
}
