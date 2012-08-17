using System;
using System.Windows.Forms;

namespace SampleWorkspacesApp.WorkSpaces
{
    public partial class WorkSpaceDlg : Form
    {
        private string m_WorksSpaceName;

        public string WorkSpaceName()
        {
            return m_WorksSpaceName;
        }

        public WorkSpaceDlg()
        {
            InitializeComponent();

            this.btnOk.Text = "Create";
            this.Text = "Creating new workspace";
        }

        public WorkSpaceDlg(string workspaceName)
        {
            InitializeComponent();

            m_WorksSpaceName = workspaceName;
            this.textBoxWorkSpaceName.Text = m_WorksSpaceName;

            this.btnOk.Text = "Rename";
            this.Text = "Renaming workspace";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            m_WorksSpaceName = textBoxWorkSpaceName.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
