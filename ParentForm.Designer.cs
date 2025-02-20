namespace ExperimentTreeViewV2
{
    partial class ParentForm
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roleFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            employeeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { appToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { roleFormToolStripMenuItem, employeeFormToolStripMenuItem });
            appToolStripMenuItem.Name = "appToolStripMenuItem";
            appToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            appToolStripMenuItem.Text = "App";
            // 
            // roleFormToolStripMenuItem
            // 
            roleFormToolStripMenuItem.Name = "roleFormToolStripMenuItem";
            roleFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            roleFormToolStripMenuItem.Text = "Role Form";
            // 
            // employeeFormToolStripMenuItem
            // 
            employeeFormToolStripMenuItem.Name = "employeeFormToolStripMenuItem";
            employeeFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            employeeFormToolStripMenuItem.Text = "Employee Form";
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "ParentForm";
            Text = "ParentForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeFormToolStripMenuItem;
    }
}