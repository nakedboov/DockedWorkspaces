using System;
using System.Xml;
using MdiTabControl;
using WeifenLuo.WinFormsUI.Docking;

namespace SampleWorkspacesApp.WorkSpaces
{
    public class WorkItemDockContent : DockContent
    {
        public EWorkItemContentType WorkItemContentType { get; set; }
        public IWorkSpaceShell ParentWorkSpaceShell { get; set; }

        public WorkItemDockContent()
        {
        }

        public WorkItemDockContent(EWorkItemContentType contentType)
        {
            InitializeComponent();

            WorkItemContentType = contentType;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WorkItemDockContent
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "WorkItemDockContent";
            this.Text = "WorkItemDockContent";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.ResumeLayout(false);

        }

        public virtual void Save(XmlTextWriter xmlWriter)
        {
            throw new NotImplementedException("Not implemented!");
        }

        public virtual void Init(XmlTextReader xmlWriter)
        {
            throw new NotImplementedException("Not implemented!");
        }
    }

    public enum EWorkItemContentType
    {
        ToolWindow = 0,
        WorkspaceDock = 1,
        WorkspaceItem = 2
    }
}
