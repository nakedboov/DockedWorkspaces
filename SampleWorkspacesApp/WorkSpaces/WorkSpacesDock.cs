using System;
using System.Globalization;
using System.Xml;

namespace SampleWorkspacesApp.WorkSpaces
{
    public sealed partial class WorkspacesDock : WorkItemDockContent
    {
        private static WorkSpaceManager _workSpaceManager;
        public static WorkSpaceManager WorkSpaceManager()
        {
            return _workSpaceManager;
        }

        public WorkspacesDock():
            base(EWorkItemContentType.WorkspaceDock)
        {
            InitializeComponent();

            _workSpaceManager = new WorkSpaceManager(new WorkSpaceContainer(this.TabControl));

            this.Text = "Workspaces area";
            this.TabText = "Workspaces area";

            _workSpaceManager.PathManageWorkSpaceContextMenu(this.ContextMenuStrip);
        }

        #region Save and Restore Configuration
        public override void Save(System.Xml.XmlTextWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(typeof(WorkspacesDock).Name);
            xmlWriter.WriteAttributeString("Count", _workSpaceManager.WorkSpacesCount().ToString(CultureInfo.InvariantCulture));

            foreach (IWorkSpaceShell workSpaceShell in WorkSpaceManager())
            {
                workSpaceShell.Save(xmlWriter);
            }
            
            xmlWriter.WriteEndElement();
        }

        public override void Init(XmlTextReader xmlTextReader)
        {
            int countOfWorkspaces = Convert.ToInt32(xmlTextReader.GetAttribute("Count"), CultureInfo.InvariantCulture);
            var workSpaceArray = new IWorkSpaceShell[countOfWorkspaces];

            for(int i =0; i < countOfWorkspaces; ++i)
            {
                PersistorExt.MoveToNextElement(xmlTextReader);

                if (xmlTextReader.Name != "Workspace")
                    throw new ArgumentException("Invalid Xml Format");

                IWorkSpaceShell workSpace = WorkSpaceManager().CreateWorkSpace(string.Empty);

                workSpace.Restore(xmlTextReader);
                workSpaceArray[i] = workSpace;
            }

            for(int i = countOfWorkspaces - 1; i >=0; --i)
            {
                WorkSpaceManager().AddWorkSpace(workSpaceArray[i]);
            }

            if (countOfWorkspaces > 0)
                WorkSpaceManager().SetActiveWorkSpace(workSpaceArray[0]);
        }
        #endregion Save and Restore Configuration
    }
}
