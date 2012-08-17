using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SampleWorkspacesApp.WorkSpaces
{
    public class WorkSpaceContainer : IWorkSpaceContainer
    {
        private readonly MdiTabControl.TabControl m_WorkSpaceContainer;

        public WorkSpaceContainer(MdiTabControl.TabControl tabcontrol)
        {
            m_WorkSpaceContainer = tabcontrol;
        }

        public IEnumerator<IWorkSpaceShell> GetEnumerator()
        {
            foreach (MdiTabControl.TabPage page in m_WorkSpaceContainer.TabPages)
            {
                yield return (WorkSpaceShell)((WorkSpaceForm)page.Form).Tag;
            }
            //return m_WorkSpaceContainer.TabPages.Cast<IWorkSpaceShell>().GetEnumerator();
        }

        public int WorkSpacesCount()
        {
            return m_WorkSpaceContainer.TabPages.Count;
        }

        public IWorkSpaceShell GetActiveWorkSpace()
        {
            MdiTabControl.TabPage page = m_WorkSpaceContainer.TabPages.SelectedTab();
            return (WorkSpaceShell)((Form)page.Form).Tag;
        }

        public void SetActiveWorkSpace(IWorkSpaceShell workSpace)
        {
            if (ReferenceEquals(workSpace, null) || !(workSpace is WorkSpaceShell))
                throw new ArgumentException("Invalid workspace");
            
            var spaceShell = (workSpace as WorkSpaceShell);

            MdiTabControl.TabPage page = m_WorkSpaceContainer.TabPages[spaceShell.WorkForm()];
            if (!ReferenceEquals(page, null))
                page.Select();
        }

        public IWorkSpaceShell CreateWorkSpace(string workSpaceName, int workSpaceId)
        {
            WorkSpaceShell workSpaceShell = new WorkSpaceShell(workSpaceName, workSpaceId);
            workSpaceShell.WorkForm().Tag = workSpaceShell;

            return workSpaceShell;
        }

        public void AddWorkSpace(IWorkSpaceShell workSpace)
        {
            if (ReferenceEquals(workSpace, null) || !(workSpace is WorkSpaceShell))
                throw new ArgumentException("Invalid workspace");

            (workSpace as WorkSpaceShell).Shell = m_WorkSpaceContainer.TabPages.Add((workSpace as WorkSpaceShell).WorkForm());
        }

        public void RemoveWorkSpace(IWorkSpaceShell workSpace)
        {
            m_WorkSpaceContainer.TabPages.Remove(((WorkSpaceShell)workSpace).Shell);
        }

        public void RemoveWorkSpace(int workSpaceId)
        {
            for (int i = 0; i < m_WorkSpaceContainer.TabPages.Count; ++i)
            {
                WorkSpaceForm workSpaceForm = (WorkSpaceForm)m_WorkSpaceContainer.TabPages[i].Form;
                WorkSpaceShell workSpaceShell = (WorkSpaceShell)workSpaceForm.Tag;

                if (workSpaceShell.WorkSpaceId() == workSpaceId)
                {
                    m_WorkSpaceContainer.TabPages.Remove(workSpaceShell.Shell);
                    break;
                }
            }
        }

        public void RenameWorkSpace(IWorkSpaceShell workSpace, string workSpaceName)
        {
            if (!ReferenceEquals(workSpace, null) && (workSpace is WorkSpaceShell))
                (workSpace as WorkSpaceShell).WorkSpaceName = workSpaceName;
        }
    }
}
