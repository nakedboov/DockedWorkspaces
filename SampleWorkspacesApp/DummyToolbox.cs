using SampleWorkspacesApp.WorkSpaces;

namespace SampleWorkspacesApp
{
    public partial class DummyToolbox : WorkItemDockContent
    {
        public DummyToolbox() :
            base(EWorkItemContentType.ToolWindow)
        {
            InitializeComponent();
        }

        public override void Save(System.Xml.XmlTextWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(typeof(DummyToolbox).Name);
            xmlWriter.WriteEndElement();
        }
    }
}