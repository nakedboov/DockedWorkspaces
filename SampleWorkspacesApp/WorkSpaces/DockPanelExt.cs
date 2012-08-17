using System.IO;
using System.Xml;
using WeifenLuo.WinFormsUI.Docking;

namespace SampleWorkspacesApp.WorkSpaces
{
    public class DockPanelExt : DockPanel
    {
        public delegate IDockContent DeserializeDockContentDelegate(string persistString, XmlTextReader xmlTextReader);

        public void Save(XmlTextWriter xmlWriter)
        {
            PersistorExt.SaveApplication(this, xmlWriter);
        }
        
        public void Restore(Stream stream, DeserializeDockContentDelegate deserializeDockContent)
        {
            PersistorExt.RestoreApplication(this, stream, deserializeDockContent);
        }
    }
}
