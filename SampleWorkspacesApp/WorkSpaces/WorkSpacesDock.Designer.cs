namespace SampleWorkspacesApp.WorkSpaces
{
    sealed partial class WorkspacesDock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl = new MdiTabControl.TabControl();
            this.m_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Alignment = MdiTabControl.TabControl.TabAlignment.Bottom;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.MenuRenderer = null;
            this.TabControl.Name = "TabControl";
            this.TabControl.Size = new System.Drawing.Size(292, 266);
            this.TabControl.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.TabControl.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Medium;
            this.TabControl.TabCloseButtonImage = null;
            this.TabControl.TabCloseButtonImageDisabled = null;
            this.TabControl.TabCloseButtonImageHot = null;
            this.TabControl.TabIndex = 0;
            this.TabControl.TabsDirection = MdiTabControl.TabControl.FlowDirection.LeftToRight;
            // 
            // m_ContextMenuStrip
            // 
            this.m_ContextMenuStrip.Name = "m_ContextMenuStrip";
            this.m_ContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // WorkspacesDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.ContextMenuStrip = this.m_ContextMenuStrip;
            this.Controls.Add(this.TabControl);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideOnClose = true;
            this.KeyPreview = true;
            this.Name = "WorkspacesDock";
            this.Text = "WorkspacesDock";
            this.ResumeLayout(false);

        }

        #endregion

        private MdiTabControl.TabControl TabControl;
        private System.Windows.Forms.ContextMenuStrip m_ContextMenuStrip;
    }
}