namespace LoginForm
{
    partial class ViewProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProjects));
            this.label1 = new System.Windows.Forms.Label();
            this.projectsLbl = new System.Windows.Forms.Label();
            this.projectsOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // projectsLbl
            // 
            this.projectsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsLbl.ForeColor = System.Drawing.Color.White;
            this.projectsLbl.Location = new System.Drawing.Point(359, 21);
            this.projectsLbl.Name = "projectsLbl";
            this.projectsLbl.Size = new System.Drawing.Size(118, 23);
            this.projectsLbl.TabIndex = 2;
            this.projectsLbl.Text = "Projects";
            // 
            // projectsOutput
            // 
            this.projectsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsOutput.ForeColor = System.Drawing.Color.White;
            this.projectsOutput.Location = new System.Drawing.Point(63, 67);
            this.projectsOutput.Name = "projectsOutput";
            this.projectsOutput.Size = new System.Drawing.Size(689, 329);
            this.projectsOutput.TabIndex = 4;
            // 
            // ViewProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectsOutput);
            this.Controls.Add(this.projectsLbl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProjects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label projectsLbl;
        private System.Windows.Forms.Label projectsOutput;
    }
}