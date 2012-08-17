using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SampleWorkspacesApp.WorkSpaces
{
    using WorkSpaceContainer = MdiTabControl.TabControl;
    
    public class WorkSpaceManager
    {
        private readonly IWorkSpaceContainer m_WorkSpaceContainer;
        private int m_WorkSpaceId;

        public WorkSpaceManager(IWorkSpaceContainer container)
        {
            m_WorkSpaceContainer = container;
            m_WorkSpaceId = 0;
        }

        public IEnumerator<IWorkSpaceShell> GetEnumerator()
        {
            return m_WorkSpaceContainer.GetEnumerator();
        }

        private int GenerateWorkSpaceId()
        {
            return ++m_WorkSpaceId;
        }

        private void OnClick_CreateWorkspace(object sender, EventArgs eventArgs)
        {
            var dlg = new WorkSpaceDlg();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                IWorkSpaceShell workSpaceShell = CreateWorkSpace(dlg.WorkSpaceName());
                AddWorkSpace(workSpaceShell);
                SetActiveWorkSpace(workSpaceShell);
            }
        }

        private void OnClick_DeleteWorkspace(object sender, EventArgs eventArgs)
        {
            RemoveWorkSpace(GetActiveWorkSpace());
        }

        private void OnClick_RenameWorkspace(object sender, EventArgs eventArgs)
        {
            RenameWorkSpace(GetActiveWorkSpace());
        }

        public IWorkSpaceShell GetActiveWorkSpace()
        {
            return m_WorkSpaceContainer.GetActiveWorkSpace();
        }

        public void SetActiveWorkSpace(IWorkSpaceShell workSpace)
        {
            m_WorkSpaceContainer.SetActiveWorkSpace(workSpace);
        }

        public IWorkSpaceShell CreateWorkSpace(string workSpaceName)
        {
            return m_WorkSpaceContainer.CreateWorkSpace(workSpaceName, GenerateWorkSpaceId());
        }

        public void AddWorkSpace(IWorkSpaceShell workSpace)
        {
            m_WorkSpaceContainer.AddWorkSpace(workSpace);
        }

        public void RemoveWorkSpace(IWorkSpaceShell workSpace)
        {
            m_WorkSpaceContainer.RemoveWorkSpace(workSpace);
        }

        public void RemoveWorkSpace(int workSpaceId)
        {
            m_WorkSpaceContainer.RemoveWorkSpace(workSpaceId);
        }

        public void RenameWorkSpace(IWorkSpaceShell workSpace)
        {
            var dlg = new WorkSpaceDlg(workSpace.WorkSpaceName());
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_WorkSpaceContainer.RenameWorkSpace(workSpace, dlg.WorkSpaceName());
            }
        }

        public int WorkSpacesCount()
        {
            return m_WorkSpaceContainer.WorkSpacesCount();
        }

        public virtual void PathManageWorkSpaceContextMenu(ContextMenuStrip contextMenu)
        {
            contextMenu.Items.Add("Create WorkSpace", null, OnClick_CreateWorkspace);
            contextMenu.Items.Add("Remove WorkSpace", null, OnClick_DeleteWorkspace);
            contextMenu.Items.Add("Rename WorkSpace", null, OnClick_RenameWorkspace);
        }

        public void MoveWorkItemToWorkSpace(WorkItemDockContent workItem, int targerWorkSpaceId)
        {
            IWorkSpaceShell workSpace = (IWorkSpaceShell)workItem.Tag;
        }

        public void AddWorkItemToActiveWorkSpace(WorkItemDockContent workItem)
        {
            IWorkSpaceShell workSpace = GetActiveWorkSpace();
            if (!ReferenceEquals(workSpace, null))
            {
                workSpace.AddWorkSpaceItem(workItem);
            }
        }
    }
}
