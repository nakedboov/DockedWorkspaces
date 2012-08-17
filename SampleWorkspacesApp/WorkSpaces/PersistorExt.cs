using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using WeifenLuo.WinFormsUI.Docking;

namespace SampleWorkspacesApp.WorkSpaces
{
    public class PersistorExt
    {
        public static string AppConfigFileVersion = "1.0.0";
        private static string[] AppCompatibleConfigFileVersions = new string[] { };

        public static void SaveApplication(DockPanel dockPanel, XmlTextWriter xmlWriter)
        {
            // Associate a version number with the root element so that future version of the code
            // will be able to be backwards compatible or at least recognise out of date versions
            xmlWriter.WriteStartElement("DockPanel");
            xmlWriter.WriteAttributeString("DockLeftPortion", dockPanel.DockLeftPortion.ToString(CultureInfo.InvariantCulture));
            xmlWriter.WriteAttributeString("DockRightPortion", dockPanel.DockRightPortion.ToString(CultureInfo.InvariantCulture));
            xmlWriter.WriteAttributeString("DockTopPortion", dockPanel.DockTopPortion.ToString(CultureInfo.InvariantCulture));
            xmlWriter.WriteAttributeString("DockBottomPortion", dockPanel.DockBottomPortion.ToString(CultureInfo.InvariantCulture));

            if (!Win32Helper.IsRunningOnMono)
            {
                xmlWriter.WriteAttributeString("ActiveDocumentPane", dockPanel.Panes.IndexOf(dockPanel.ActiveDocumentPane).ToString(CultureInfo.InvariantCulture));
                xmlWriter.WriteAttributeString("ActivePane", dockPanel.Panes.IndexOf(dockPanel.ActivePane).ToString(CultureInfo.InvariantCulture));
            }

            // Contents
            xmlWriter.WriteStartElement("Contents");
            xmlWriter.WriteAttributeString("Count", dockPanel.Contents.Count.ToString(CultureInfo.InvariantCulture));
            foreach (WorkItemDockContent content in dockPanel.Contents)
            {
                xmlWriter.WriteStartElement("Content");
                xmlWriter.WriteAttributeString("ID", dockPanel.Contents.IndexOf(content).ToString(CultureInfo.InvariantCulture));
                xmlWriter.WriteAttributeString("AutoHidePortion", content.DockHandler.AutoHidePortion.ToString(CultureInfo.InvariantCulture));
                xmlWriter.WriteAttributeString("IsHidden", content.DockHandler.IsHidden.ToString(CultureInfo.InvariantCulture));
                xmlWriter.WriteAttributeString("IsFloat", content.DockHandler.IsFloat.ToString(CultureInfo.InvariantCulture));

                content.Save(xmlWriter);

                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();

            // Panes
            xmlWriter.WriteStartElement("Panes");
            xmlWriter.WriteAttributeString("Count", dockPanel.Panes.Count.ToString(CultureInfo.InvariantCulture));
            foreach (DockPane pane in dockPanel.Panes)
            {
                xmlWriter.WriteStartElement("Pane");
                xmlWriter.WriteAttributeString("ID", dockPanel.Panes.IndexOf(pane).ToString(CultureInfo.InvariantCulture));
                xmlWriter.WriteAttributeString("DockState", pane.DockState.ToString());
                xmlWriter.WriteAttributeString("ActiveContent", dockPanel.Contents.IndexOf(pane.ActiveContent).ToString(CultureInfo.InvariantCulture));
                xmlWriter.WriteStartElement("Contents");
                xmlWriter.WriteAttributeString("Count", pane.Contents.Count.ToString(CultureInfo.InvariantCulture));
                foreach (IDockContent content in pane.Contents)
                {
                    xmlWriter.WriteStartElement("Content");
                    xmlWriter.WriteAttributeString("ID", pane.Contents.IndexOf(content).ToString(CultureInfo.InvariantCulture));
                    xmlWriter.WriteAttributeString("RefID", dockPanel.Contents.IndexOf(content).ToString(CultureInfo.InvariantCulture));
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();

            // DockWindows
            xmlWriter.WriteStartElement("DockWindows");
            int dockWindowId = 0;
            foreach (DockWindow dw in dockPanel.DockWindows)
            {
                xmlWriter.WriteStartElement("DockWindow");
                xmlWriter.WriteAttributeString("ID", dockWindowId.ToString(CultureInfo.InvariantCulture));
                dockWindowId++;
                xmlWriter.WriteAttributeString("DockState", dw.DockState.ToString());
                xmlWriter.WriteAttributeString("ZOrderIndex", dockPanel.Controls.IndexOf(dw).ToString(CultureInfo.InvariantCulture));
                xmlWriter.WriteStartElement("NestedPanes");
                xmlWriter.WriteAttributeString("Count", dw.NestedPanes.Count.ToString(CultureInfo.InvariantCulture));
                foreach (DockPane pane in dw.NestedPanes)
                {
                    xmlWriter.WriteStartElement("Pane");
                    xmlWriter.WriteAttributeString("ID", dw.NestedPanes.IndexOf(pane).ToString(CultureInfo.InvariantCulture));
                    xmlWriter.WriteAttributeString("RefID", dockPanel.Panes.IndexOf(pane).ToString(CultureInfo.InvariantCulture));
                    NestedDockingStatus status = pane.NestedDockingStatus;
                    xmlWriter.WriteAttributeString("PrevPane", dockPanel.Panes.IndexOf(status.PreviousPane).ToString(CultureInfo.InvariantCulture));
                    xmlWriter.WriteAttributeString("Alignment", status.Alignment.ToString());
                    xmlWriter.WriteAttributeString("Proportion", status.Proportion.ToString(CultureInfo.InvariantCulture));
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();

            // FloatWindows
            var rectConverter = new RectangleConverter();
            xmlWriter.WriteStartElement("FloatWindows");
            xmlWriter.WriteAttributeString("Count", dockPanel.FloatWindows.Count.ToString(CultureInfo.InvariantCulture));
            foreach (FloatWindow fw in dockPanel.FloatWindows)
            {
                xmlWriter.WriteStartElement("FloatWindow");
                xmlWriter.WriteAttributeString("ID", dockPanel.FloatWindows.IndexOf(fw).ToString(CultureInfo.InvariantCulture));
                xmlWriter.WriteAttributeString("Bounds", rectConverter.ConvertToInvariantString(fw.Bounds));
                xmlWriter.WriteAttributeString("ZOrderIndex", fw.DockPanel.FloatWindows.IndexOf(fw).ToString(CultureInfo.InvariantCulture));
                xmlWriter.WriteStartElement("NestedPanes");
                xmlWriter.WriteAttributeString("Count", fw.NestedPanes.Count.ToString(CultureInfo.InvariantCulture));
                foreach (DockPane pane in fw.NestedPanes)
                {
                    xmlWriter.WriteStartElement("Pane");
                    xmlWriter.WriteAttributeString("ID", fw.NestedPanes.IndexOf(pane).ToString(CultureInfo.InvariantCulture));
                    xmlWriter.WriteAttributeString("RefID", dockPanel.Panes.IndexOf(pane).ToString(CultureInfo.InvariantCulture));
                    NestedDockingStatus status = pane.NestedDockingStatus;
                    xmlWriter.WriteAttributeString("PrevPane", dockPanel.Panes.IndexOf(status.PreviousPane).ToString(CultureInfo.InvariantCulture));
                    xmlWriter.WriteAttributeString("Alignment", status.Alignment.ToString());
                    xmlWriter.WriteAttributeString("Proportion", status.Proportion.ToString(CultureInfo.InvariantCulture));
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();	//	</FloatWindows>

            xmlWriter.WriteEndElement();
        }

        public static void RestoreApplication(DockPanel dockPanel, Stream stream, DockPanelExt.DeserializeDockContentDelegate deserializeDockContent)
        {
            if (dockPanel.Contents.Count != 0)
                throw new InvalidOperationException("DockPanel is Already Initialized");

            var xmlIn = new XmlTextReader(stream) { WhitespaceHandling = WhitespaceHandling.None };
            xmlIn.MoveToContent();

            while (!xmlIn.Name.Equals("ApplicationDocks"))
            {
                if (!MoveToNextElement(xmlIn))
                    throw new ArgumentException("Invalid Xml Format");
            }

            string formatVersion = xmlIn.GetAttribute("FormatVersion");
            if (!IsFormatVersionValid(formatVersion))
                throw new ArgumentException("Invalid FormatVersion");

            MoveToNextElement(xmlIn);

            RestoreDockPanel(dockPanel, xmlIn, deserializeDockContent);
        }

        public static void RestoreDockPanel(DockPanel dockPanel, XmlTextReader xmlIn, DockPanelExt.DeserializeDockContentDelegate deserializeDockContent)
        {
            if (xmlIn.Name != "DockPanel")
                throw new ArgumentException("Invalid Xml Format");

            var dockPanelStruct = new DockPanelStruct();
            dockPanelStruct.DockLeftPortion = Convert.ToDouble(xmlIn.GetAttribute("DockLeftPortion"), CultureInfo.InvariantCulture);
            dockPanelStruct.DockRightPortion = Convert.ToDouble(xmlIn.GetAttribute("DockRightPortion"), CultureInfo.InvariantCulture);
            dockPanelStruct.DockTopPortion = Convert.ToDouble(xmlIn.GetAttribute("DockTopPortion"), CultureInfo.InvariantCulture);
            dockPanelStruct.DockBottomPortion = Convert.ToDouble(xmlIn.GetAttribute("DockBottomPortion"), CultureInfo.InvariantCulture);
            dockPanelStruct.IndexActiveDocumentPane = Convert.ToInt32(xmlIn.GetAttribute("ActiveDocumentPane"), CultureInfo.InvariantCulture);
            dockPanelStruct.IndexActivePane = Convert.ToInt32(xmlIn.GetAttribute("ActivePane"), CultureInfo.InvariantCulture);

            // Load Contents
            MoveToNextElement(xmlIn);
            if (xmlIn.Name != "Contents")
                throw new ArgumentException("Invalid Xml Format");
           
            ContentStruct[] contents = LoadAndCreateContents(dockPanel, xmlIn, deserializeDockContent);

            // Load Panes
            MoveToNextElement(xmlIn);
            if (xmlIn.Name != "Panes")
                throw new ArgumentException("Invalid Xml Format");
            PaneStruct[] panes = LoadPanes(xmlIn);

            // Load DockWindows
            MoveToNextElement(xmlIn);
            if (xmlIn.Name != "DockWindows")
                throw new ArgumentException("Invalid Xml Format");
            DockWindowStruct[] dockWindows = LoadDockWindows(xmlIn, dockPanel);

            // Load FloatWindows
            MoveToNextElement(xmlIn);
            if (xmlIn.Name != "FloatWindows")
                throw new ArgumentException("Invalid Xml Format");
            FloatWindowStruct[] floatWindows = LoadFloatWindows(xmlIn);

            dockPanel.SuspendLayout(true);

            dockPanel.DockLeftPortion = dockPanelStruct.DockLeftPortion;
            dockPanel.DockRightPortion = dockPanelStruct.DockRightPortion;
            dockPanel.DockTopPortion = dockPanelStruct.DockTopPortion;
            dockPanel.DockBottomPortion = dockPanelStruct.DockBottomPortion;

            // Set DockWindow ZOrders
            int prevMaxDockWindowZOrder = int.MaxValue;
            for (int i = 0; i < dockWindows.Length; i++)
            {
                int maxDockWindowZOrder = -1;
                int index = -1;
                for (int j = 0; j < dockWindows.Length; j++)
                {
                    if (dockWindows[j].ZOrderIndex > maxDockWindowZOrder && dockWindows[j].ZOrderIndex < prevMaxDockWindowZOrder)
                    {
                        maxDockWindowZOrder = dockWindows[j].ZOrderIndex;
                        index = j;
                    }
                }

                dockPanel.DockWindows[dockWindows[index].DockState].BringToFront();
                prevMaxDockWindowZOrder = maxDockWindowZOrder;
            }

            // Create panes
            foreach (PaneStruct t in panes)
            {
                DockPane pane = null;
                for (int j = 0; j < t.IndexContents.Length; j++)
                {
                    IDockContent content = dockPanel.Contents[t.IndexContents[j]];
                    if (j == 0)
                        pane = dockPanel.DockPaneFactory.CreateDockPane(content, t.DockState, false);
                    else if (t.DockState == DockState.Float)
                        content.DockHandler.FloatPane = pane;
                    else
                        content.DockHandler.PanelPane = pane;
                }
            }

            // Assign Panes to DockWindows
            foreach (DockWindowStruct t in dockWindows)
            {
                for (int j = 0; j < t.NestedPanes.Length; j++)
                {
                    DockWindow dw = dockPanel.DockWindows[t.DockState];
                    int indexPane = t.NestedPanes[j].IndexPane;
                    DockPane pane = dockPanel.Panes[indexPane];
                    int indexPrevPane = t.NestedPanes[j].IndexPrevPane;
                    DockPane prevPane = (indexPrevPane == -1) ? dw.NestedPanes.GetDefaultPreviousPane(pane) : dockPanel.Panes[indexPrevPane];
                    DockAlignment alignment = t.NestedPanes[j].Alignment;
                    double proportion = t.NestedPanes[j].Proportion;
                    pane.DockTo(dw, prevPane, alignment, proportion);
                    if (panes[indexPane].DockState == dw.DockState)
                        panes[indexPane].ZOrderIndex = t.ZOrderIndex;
                }
            }

            // Create float windows
            foreach (FloatWindowStruct t in floatWindows)
            {
                FloatWindow fw = null;
                for (int j = 0; j < t.NestedPanes.Length; j++)
                {
                    int indexPane = t.NestedPanes[j].IndexPane;
                    DockPane pane = dockPanel.Panes[indexPane];
                    if (j == 0)
                        fw = dockPanel.FloatWindowFactory.CreateFloatWindow(dockPanel, pane, t.Bounds);
                    else
                    {
                        int indexPrevPane = t.NestedPanes[j].IndexPrevPane;
                        DockPane prevPane = indexPrevPane == -1 ? null : dockPanel.Panes[indexPrevPane];
                        DockAlignment alignment = t.NestedPanes[j].Alignment;
                        double proportion = t.NestedPanes[j].Proportion;
                        pane.DockTo(fw, prevPane, alignment, proportion);
                    }

                    if (panes[indexPane].DockState == fw.DockState)
                        panes[indexPane].ZOrderIndex = t.ZOrderIndex;
                }
            }

            // sort IDockContent by its Pane's ZOrder
            int[] sortedContents = null;
            if (contents.Length > 0)
            {
                sortedContents = new int[contents.Length];
                for (int i = 0; i < contents.Length; i++)
                    sortedContents[i] = i;

                int lastDocument = contents.Length;
                for (int i = 0; i < contents.Length - 1; i++)
                {
                    for (int j = i + 1; j < contents.Length; j++)
                    {
                        DockPane pane1 = dockPanel.Contents[sortedContents[i]].DockHandler.Pane;
                        int ZOrderIndex1 = pane1 == null ? 0 : panes[dockPanel.Panes.IndexOf(pane1)].ZOrderIndex;
                        DockPane pane2 = dockPanel.Contents[sortedContents[j]].DockHandler.Pane;
                        int ZOrderIndex2 = pane2 == null ? 0 : panes[dockPanel.Panes.IndexOf(pane2)].ZOrderIndex;
                        if (ZOrderIndex1 > ZOrderIndex2)
                        {
                            int temp = sortedContents[i];
                            sortedContents[i] = sortedContents[j];
                            sortedContents[j] = temp;
                        }
                    }
                }
            }

            // show non-document IDockContent first to avoid screen flickers
            for (int i = 0; i < contents.Length; i++)
            {
                IDockContent content = dockPanel.Contents[sortedContents[i]];
                if (content.DockHandler.Pane != null && content.DockHandler.Pane.DockState != DockState.Document)
                    content.DockHandler.IsHidden = contents[sortedContents[i]].IsHidden;
            }

            // after all non-document IDockContent, show document IDockContent
            for (int i = 0; i < contents.Length; i++)
            {
                IDockContent content = dockPanel.Contents[sortedContents[i]];
                if (content.DockHandler.Pane != null && content.DockHandler.Pane.DockState == DockState.Document)
                    content.DockHandler.IsHidden = contents[sortedContents[i]].IsHidden;
            }

            for (int i = 0; i < panes.Length; i++)
                dockPanel.Panes[i].ActiveContent = panes[i].IndexActiveContent == -1 ? null : dockPanel.Contents[panes[i].IndexActiveContent];

            if (dockPanelStruct.IndexActiveDocumentPane != -1)
                dockPanel.Panes[dockPanelStruct.IndexActiveDocumentPane].Activate();

            if (dockPanelStruct.IndexActivePane != -1)
                dockPanel.Panes[dockPanelStruct.IndexActivePane].Activate();

            for (int i = dockPanel.Contents.Count - 1; i >= 0; i--)
                if (dockPanel.Contents[i] is DummyContent)
                    dockPanel.Contents[i].DockHandler.Form.Close();

            dockPanel.ResumeLayout(true, true);
        }

        private class DummyContent : DockContent
        {
        }

        private struct DockPanelStruct
        {
            private double m_DockLeftPortion;
            public double DockLeftPortion
            {
                get { return m_DockLeftPortion; }
                set { m_DockLeftPortion = value; }
            }

            private double m_DockRightPortion;
            public double DockRightPortion
            {
                get { return m_DockRightPortion; }
                set { m_DockRightPortion = value; }
            }

            private double m_DockTopPortion;
            public double DockTopPortion
            {
                get { return m_DockTopPortion; }
                set { m_DockTopPortion = value; }
            }

            private double m_DockBottomPortion;
            public double DockBottomPortion
            {
                get { return m_DockBottomPortion; }
                set { m_DockBottomPortion = value; }
            }

            private int m_IndexActiveDocumentPane;
            public int IndexActiveDocumentPane
            {
                get { return m_IndexActiveDocumentPane; }
                set { m_IndexActiveDocumentPane = value; }
            }

            private int m_IndexActivePane;
            public int IndexActivePane
            {
                get { return m_IndexActivePane; }
                set { m_IndexActivePane = value; }
            }
        }

        private struct ContentStruct
        {
            private string m_PersistString;
            public string PersistString
            {
                get { return m_PersistString; }
                set { m_PersistString = value; }
            }

            private double m_AutoHidePortion;
            public double AutoHidePortion
            {
                get { return m_AutoHidePortion; }
                set { m_AutoHidePortion = value; }
            }

            private bool m_IsHidden;
            public bool IsHidden
            {
                get { return m_IsHidden; }
                set { m_IsHidden = value; }
            }

            private bool m_IsFloat;
            public bool IsFloat
            {
                get { return m_IsFloat; }
                set { m_IsFloat = value; }
            }
        }

        private struct PaneStruct
        {
            private DockState m_DockState;
            public DockState DockState
            {
                get { return m_DockState; }
                set { m_DockState = value; }
            }

            private int m_IndexActiveContent;
            public int IndexActiveContent
            {
                get { return m_IndexActiveContent; }
                set { m_IndexActiveContent = value; }
            }

            private int[] m_IndexContents;
            public int[] IndexContents
            {
                get { return m_IndexContents; }
                set { m_IndexContents = value; }
            }

            private int m_ZOrderIndex;
            public int ZOrderIndex
            {
                get { return m_ZOrderIndex; }
                set { m_ZOrderIndex = value; }
            }
        }

        private struct NestedPane
        {
            private int m_IndexPane;
            public int IndexPane
            {
                get { return m_IndexPane; }
                set { m_IndexPane = value; }
            }

            private int m_IndexPrevPane;
            public int IndexPrevPane
            {
                get { return m_IndexPrevPane; }
                set { m_IndexPrevPane = value; }
            }

            private DockAlignment m_Alignment;
            public DockAlignment Alignment
            {
                get { return m_Alignment; }
                set { m_Alignment = value; }
            }

            private double m_Proportion;
            public double Proportion
            {
                get { return m_Proportion; }
                set { m_Proportion = value; }
            }
        }

        private struct DockWindowStruct
        {
            private DockState m_DockState;
            public DockState DockState
            {
                get { return m_DockState; }
                set { m_DockState = value; }
            }

            private int m_ZOrderIndex;
            public int ZOrderIndex
            {
                get { return m_ZOrderIndex; }
                set { m_ZOrderIndex = value; }
            }

            private NestedPane[] m_NestedPanes;
            public NestedPane[] NestedPanes
            {
                get { return m_NestedPanes; }
                set { m_NestedPanes = value; }
            }
        }

        private struct FloatWindowStruct
        {
            private Rectangle m_Bounds;
            public Rectangle Bounds
            {
                get { return m_Bounds; }
                set { m_Bounds = value; }
            }

            private int m_ZOrderIndex;
            public int ZOrderIndex
            {
                get { return m_ZOrderIndex; }
                set { m_ZOrderIndex = value; }
            }

            private NestedPane[] m_NestedPanes;
            public NestedPane[] NestedPanes
            {
                get { return m_NestedPanes; }
                set { m_NestedPanes = value; }
            }
        }

        public static bool MoveToNextElement(XmlTextReader xmlIn)
        {
            if (!xmlIn.Read())
                return false;

            while (xmlIn.NodeType == XmlNodeType.EndElement)
            {
                if (!xmlIn.Read())
                    return false;
            }

            return true;
        }

        private static bool IsFormatVersionValid(string formatVersion)
        {
            if (formatVersion == AppConfigFileVersion)
                return true;

            return AppCompatibleConfigFileVersions.Any(s => s == formatVersion);
        }

        private static ContentStruct[] LoadAndCreateContents(DockPanel dockPanel, XmlTextReader xmlIn, DockPanelExt.DeserializeDockContentDelegate deserializeDockContent)
        {
            int countOfContents = Convert.ToInt32(xmlIn.GetAttribute("Count"), CultureInfo.InvariantCulture);
            ContentStruct[] contents = new ContentStruct[countOfContents];
            
            for (int i = 0; i < countOfContents; i++)
            {
                MoveToNextElement(xmlIn);

                int id = Convert.ToInt32(xmlIn.GetAttribute("ID"), CultureInfo.InvariantCulture);
                if (xmlIn.Name != "Content" || id != i)
                    throw new ArgumentException("Invalid Xml Format");

                contents[i].AutoHidePortion = Convert.ToDouble(xmlIn.GetAttribute("AutoHidePortion"), CultureInfo.InvariantCulture);
                contents[i].IsHidden = Convert.ToBoolean(xmlIn.GetAttribute("IsHidden"), CultureInfo.InvariantCulture);
                contents[i].IsFloat = Convert.ToBoolean(xmlIn.GetAttribute("IsFloat"), CultureInfo.InvariantCulture);

                MoveToNextElement(xmlIn);

                IDockContent content = deserializeDockContent(xmlIn.LocalName, xmlIn) ?? new DummyContent();

                content.DockHandler.DockPanel = dockPanel;
                content.DockHandler.AutoHidePortion = contents[i].AutoHidePortion;
                content.DockHandler.IsHidden = true;
                content.DockHandler.IsFloat = contents[i].IsFloat;

                //MoveToNextElement(xmlIn);
            }

            return contents;
        }

        private static PaneStruct[] LoadPanes(XmlTextReader xmlIn)
        {
            EnumConverter dockStateConverter = new EnumConverter(typeof(DockState));
            int countOfPanes = Convert.ToInt32(xmlIn.GetAttribute("Count"), CultureInfo.InvariantCulture);
            PaneStruct[] panes = new PaneStruct[countOfPanes];
            
            for (int i = 0; i < countOfPanes; i++)
            {
                MoveToNextElement(xmlIn);

                int id = Convert.ToInt32(xmlIn.GetAttribute("ID"), CultureInfo.InvariantCulture);
                if (xmlIn.Name != "Pane" || id != i)
                    throw new ArgumentException("Invalid Xml Format");

                panes[i].DockState = (DockState)dockStateConverter.ConvertFrom(xmlIn.GetAttribute("DockState"));
                panes[i].IndexActiveContent = Convert.ToInt32(xmlIn.GetAttribute("ActiveContent"), CultureInfo.InvariantCulture);
                panes[i].ZOrderIndex = -1;

                MoveToNextElement(xmlIn);
                if (xmlIn.Name != "Contents")
                    throw new ArgumentException("Invalid Xml Format");
                int countOfPaneContents = Convert.ToInt32(xmlIn.GetAttribute("Count"), CultureInfo.InvariantCulture);
                panes[i].IndexContents = new int[countOfPaneContents];
                
                for (int j = 0; j < countOfPaneContents; j++)
                {
                    MoveToNextElement(xmlIn);

                    int id2 = Convert.ToInt32(xmlIn.GetAttribute("ID"), CultureInfo.InvariantCulture);
                    if (xmlIn.Name != "Content" || id2 != j)
                        throw new ArgumentException("Invalid Xml Format");

                    panes[i].IndexContents[j] = Convert.ToInt32(xmlIn.GetAttribute("RefID"), CultureInfo.InvariantCulture);
                    //MoveToNextElement(xmlIn);
                }
            }

            return panes;
        }

        private static DockWindowStruct[] LoadDockWindows(XmlTextReader xmlIn, DockPanel dockPanel)
        {
            EnumConverter dockStateConverter = new EnumConverter(typeof(DockState));
            EnumConverter dockAlignmentConverter = new EnumConverter(typeof(DockAlignment));
            int countOfDockWindows = dockPanel.DockWindows.Count;
            DockWindowStruct[] dockWindows = new DockWindowStruct[countOfDockWindows];
            
            for (int i = 0; i < countOfDockWindows; i++)
            {
                MoveToNextElement(xmlIn);

                int id = Convert.ToInt32(xmlIn.GetAttribute("ID"), CultureInfo.InvariantCulture);
                if (xmlIn.Name != "DockWindow" || id != i)
                    throw new ArgumentException("Invalid Xml Format");

                dockWindows[i].DockState = (DockState)dockStateConverter.ConvertFrom(xmlIn.GetAttribute("DockState"));
                dockWindows[i].ZOrderIndex = Convert.ToInt32(xmlIn.GetAttribute("ZOrderIndex"), CultureInfo.InvariantCulture);
                MoveToNextElement(xmlIn);
                if (xmlIn.Name != "DockList" && xmlIn.Name != "NestedPanes")
                    throw new ArgumentException("Invalid Xml Format");
                int countOfNestedPanes = Convert.ToInt32(xmlIn.GetAttribute("Count"), CultureInfo.InvariantCulture);
                dockWindows[i].NestedPanes = new NestedPane[countOfNestedPanes];
                
                for (int j = 0; j < countOfNestedPanes; j++)
                {
                    MoveToNextElement(xmlIn);

                    int id2 = Convert.ToInt32(xmlIn.GetAttribute("ID"), CultureInfo.InvariantCulture);
                    if (xmlIn.Name != "Pane" || id2 != j)
                        throw new ArgumentException("Invalid Xml Format");
                    dockWindows[i].NestedPanes[j].IndexPane = Convert.ToInt32(xmlIn.GetAttribute("RefID"), CultureInfo.InvariantCulture);
                    dockWindows[i].NestedPanes[j].IndexPrevPane = Convert.ToInt32(xmlIn.GetAttribute("PrevPane"), CultureInfo.InvariantCulture);
                    dockWindows[i].NestedPanes[j].Alignment = (DockAlignment)dockAlignmentConverter.ConvertFrom(xmlIn.GetAttribute("Alignment"));
                    dockWindows[i].NestedPanes[j].Proportion = Convert.ToDouble(xmlIn.GetAttribute("Proportion"), CultureInfo.InvariantCulture);
                    //MoveToNextElement(xmlIn);
                }
            }

            return dockWindows;
        }

        private static FloatWindowStruct[] LoadFloatWindows(XmlTextReader xmlIn)
        {
            EnumConverter dockAlignmentConverter = new EnumConverter(typeof(DockAlignment));
            RectangleConverter rectConverter = new RectangleConverter();
            int countOfFloatWindows = Convert.ToInt32(xmlIn.GetAttribute("Count"), CultureInfo.InvariantCulture);
            FloatWindowStruct[] floatWindows = new FloatWindowStruct[countOfFloatWindows];
            
            for (int i = 0; i < countOfFloatWindows; i++)
            {
                MoveToNextElement(xmlIn);

                int id = Convert.ToInt32(xmlIn.GetAttribute("ID"), CultureInfo.InvariantCulture);
                if (xmlIn.Name != "FloatWindow" || id != i)
                    throw new ArgumentException("Invalid Xml Format");

                floatWindows[i].Bounds = (Rectangle)rectConverter.ConvertFromInvariantString(xmlIn.GetAttribute("Bounds"));
                floatWindows[i].ZOrderIndex = Convert.ToInt32(xmlIn.GetAttribute("ZOrderIndex"), CultureInfo.InvariantCulture);
                MoveToNextElement(xmlIn);
                if (xmlIn.Name != "DockList" && xmlIn.Name != "NestedPanes")
                    throw new ArgumentException("Invalid Xml Format");
                int countOfNestedPanes = Convert.ToInt32(xmlIn.GetAttribute("Count"), CultureInfo.InvariantCulture);
                floatWindows[i].NestedPanes = new NestedPane[countOfNestedPanes];
                
                for (int j = 0; j < countOfNestedPanes; j++)
                {
                    MoveToNextElement(xmlIn);

                    int id2 = Convert.ToInt32(xmlIn.GetAttribute("ID"), CultureInfo.InvariantCulture);
                    if (xmlIn.Name != "Pane" || id2 != j)
                        throw new ArgumentException("Invalid Xml Format");
                    floatWindows[i].NestedPanes[j].IndexPane = Convert.ToInt32(xmlIn.GetAttribute("RefID"), CultureInfo.InvariantCulture);
                    floatWindows[i].NestedPanes[j].IndexPrevPane = Convert.ToInt32(xmlIn.GetAttribute("PrevPane"), CultureInfo.InvariantCulture);
                    floatWindows[i].NestedPanes[j].Alignment = (DockAlignment)dockAlignmentConverter.ConvertFrom(xmlIn.GetAttribute("Alignment"));
                    floatWindows[i].NestedPanes[j].Proportion = Convert.ToDouble(xmlIn.GetAttribute("Proportion"), CultureInfo.InvariantCulture);
                    //MoveToNextElement(xmlIn);
                }
            }

            return floatWindows;
        }
    }
}
