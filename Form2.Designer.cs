namespace ExperimentTreeViewV2
{
    partial class Form2
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
            treeViewRole = new System.Windows.Forms.TreeView();
            textboxAnalyze = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // treeViewRole
            // 
            treeViewRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            treeViewRole.Location = new System.Drawing.Point(508, 10);
            treeViewRole.Name = "treeViewRole";
            treeViewRole.Size = new System.Drawing.Size(697, 519);
            treeViewRole.TabIndex = 12;
            // 
            // textboxAnalyze
            // 
            textboxAnalyze.Location = new System.Drawing.Point(9, 142);
            textboxAnalyze.Multiline = true;
            textboxAnalyze.Name = "textboxAnalyze";
            textboxAnalyze.Size = new System.Drawing.Size(472, 387);
            textboxAnalyze.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 577);
            Controls.Add(treeViewRole);
            Controls.Add(textboxAnalyze);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TreeView treeViewRole;
        private System.Windows.Forms.TextBox textboxAnalyze;
    }
}