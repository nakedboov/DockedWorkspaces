using System.Collections.Generic;

namespace SampleWorkspacesApp.WorkSpaces
{
    public interface IWorkSpaceContainer
    {
        IWorkSpaceShell GetActiveWorkSpace();
        void SetActiveWorkSpace(IWorkSpaceShell workSpace);

        IWorkSpaceShell CreateWorkSpace(string workSpaceName, int workSpaceId);
        void AddWorkSpace(IWorkSpaceShell workSpace);
        void RemoveWorkSpace(IWorkSpaceShell workSpace);
        void RemoveWorkSpace(int workSpaceId);
        void RenameWorkSpace(IWorkSpaceShell workSpace, string workSpaceName);
        int WorkSpacesCount();

        IEnumerator<IWorkSpaceShell> GetEnumerator();
    }
}
