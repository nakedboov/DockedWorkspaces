using System.Xml;

namespace SampleWorkspacesApp.WorkSpaces
{
    public interface IWorkSpaceShell
    {
        void AddWorkSpaceItem(WorkItemDockContent workItem);
        void RemoveWorkSpaceItem(WorkItemDockContent workItem);
        string WorkSpaceName();

        void MoveTo(WorkItemDockContent workItem);
        
        void Save(XmlTextWriter xmlWriter);
        void Restore(XmlTextReader xmlReader);
    }
}
