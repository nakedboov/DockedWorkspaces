using System.Drawing;
using SampleWorkspacesApp.WorkSpaces;

namespace SampleWorkspacesApp
{
    public partial class DummyTaskList : WorkItemDockContent
    {
        public DummyTaskList() :
            base(EWorkItemContentType.ToolWindow)
        {
            InitializeComponent();
        }

        public override void Save(System.Xml.XmlTextWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(typeof(DummyTaskList).Name);
            xmlWriter.WriteEndElement();
        }
    }
}