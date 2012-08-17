using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SampleWorkspacesApp.WorkSpaces;
using WeifenLuo.WinFormsUI.Docking;

namespace SampleWorkspacesApp
{
    public partial class MainForm : Form
    {
        private readonly WorkspacesDock m_WorkspacesDock = new WorkspacesDock();
        private readonly DummyTaskList m_MainTaskList = new DummyTaskList();
        private readonly DummyToolbox m_MainToolBox = new DummyToolbox();

        private readonly DockPanelExt.DeserializeDockContentDelegate m_DeserializeDockContent;

        private const string AppConfigFile = "ApplicationDocks.config";
        
        public MainForm()
        {
            InitializeComponent();

            m_DeserializeDockContent = DeserializeDockContent;

            //m_MainTaskList.Show(MainDockPanel);
            //m_MainToolBox.Show(MainDockPanel);
            //m_WorkspacesDock.Show(MainDockPanel);
        }

        private void MenuItem_NewTaskList_Click(object sender, EventArgs e)
        {
            WorkspacesDock.WorkSpaceManager().AddWorkItemToActiveWorkSpace(new WorkSpaceItemWindow());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RestoreAppConfiguration();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAppConfiguration();
        }

        #region Save and Restore Configuration
        private void SaveAppConfiguration()
        {
            var xmlWriter = new XmlTextWriter(AppConfigFile, Encoding.Unicode) { Formatting = Formatting.Indented };
            try
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteComment("!!! AUTOMATICALLY GENERATED FILE. DO NOT MODIFY !!!");

                xmlWriter.WriteStartElement("ApplicationDocks");
                xmlWriter.WriteAttributeString("FormatVersion", PersistorExt.AppConfigFileVersion);

                MainDockPanel.Save(xmlWriter);

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
            finally
            {
                xmlWriter.Flush();
                xmlWriter.Close();
            }
        }

        private void RestoreAppConfiguration()
        {
            if (!File.Exists(AppConfigFile))
            {
                RestoreDefaultConfig();
                return;
            }

            var fs = new FileStream(AppConfigFile, FileMode.Open, FileAccess.Read);
            try
            {
                MainDockPanel.Restore(fs, m_DeserializeDockContent);
            }
            finally
            {
                fs.Close();
            }
        }

        private void RestoreDefaultConfig()
        {
            using (var memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(Properties.Resources.ApplicationDefaultDocks)))
            {
                MainDockPanel.Restore(memoryStream, m_DeserializeDockContent);
                memoryStream.Close();
            }
        }

        private IDockContent DeserializeDockContent(string persistString, XmlTextReader xmlTextReader)
        {
            if (persistString.Equals(typeof(DummyToolbox).Name))
                return RestoreToolBox(xmlTextReader);
            if (persistString.Equals(typeof(DummyTaskList).Name))
                return RestoreTaskList(xmlTextReader);
            if (persistString.Equals(typeof(WorkspacesDock).Name))
                return RestoreWorkspacesDock(xmlTextReader);

            return null;
        }

        private IDockContent RestoreWorkspacesDock(XmlTextReader xmlTextReader)
        {
            m_WorkspacesDock.Init(xmlTextReader);
            return m_WorkspacesDock;
        }

        private IDockContent RestoreTaskList(XmlTextReader xmlTextReader)
        {
            return m_MainTaskList;
        }

        private IDockContent RestoreToolBox(XmlTextReader xmlTextReader)
        {
            return m_MainToolBox;
        }
        #endregion Save and Restore Configuration
    }
}
