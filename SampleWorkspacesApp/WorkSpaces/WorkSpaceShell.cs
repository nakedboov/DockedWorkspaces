using System.Windows.Forms;
using System.Xml;

namespace SampleWorkspacesApp.WorkSpaces
{
    using TabPage = MdiTabControl.TabPage;

    public class WorkSpaceShell : IWorkSpaceShell
    {
        //private MdiTabControl.TabPage m_Shell;
        public TabPage Shell { get; set; }

        private readonly WorkSpaceForm m_WorkSpaceForm;
        public Form WorkForm()
        {
            return m_WorkSpaceForm;
        }

        private readonly int m_WorkSpaceId;
        public int WorkSpaceId()
        {
            return m_WorkSpaceId;
        }

        private string m_WorkSpaceName;
        public string WorkSpaceName 
        {
            get { return m_WorkSpaceName;} 
            set { 
                    m_WorkSpaceName = value;
                    m_WorkSpaceForm.Text = m_WorkSpaceName;
                }
        }
        
        public WorkSpaceShell(string workSpaceName, int workSpaceId)
        {
            m_WorkSpaceName = workSpaceName;
            m_WorkSpaceId = workSpaceId;

            m_WorkSpaceForm = new WorkSpaceForm(m_WorkSpaceName);
        }

        void IWorkSpaceShell.AddWorkSpaceItem(WorkItemDockContent workItem)
        {
            m_WorkSpaceForm.AddItem(workItem);
            workItem.ParentWorkSpaceShell = this;
        }

        void IWorkSpaceShell.RemoveWorkSpaceItem(WorkItemDockContent workItem)
        {
            m_WorkSpaceForm.RemoveItem(workItem);
        }

        string IWorkSpaceShell.WorkSpaceName()
        {
            return m_WorkSpaceName;
        }

        void IWorkSpaceShell.MoveTo(WorkItemDockContent workItem)
        {
            m_WorkSpaceForm.MoveTo(workItem, this);
        }

        void IWorkSpaceShell.Save(XmlTextWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("Workspace");
            xmlWriter.WriteAttributeString("Name", m_WorkSpaceName);

            m_WorkSpaceForm.SaveAllItems(xmlWriter);

            xmlWriter.WriteEndElement();
        }

        public void Restore(XmlTextReader xmlReader)
        {
            m_WorkSpaceName = xmlReader.GetAttribute("Name");
            m_WorkSpaceForm.Text = m_WorkSpaceName;

            m_WorkSpaceForm.RestoreAllItems(xmlReader);
        }
    }
}
