namespace LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.projectNameInput = new System.Windows.Forms.TextBox();
            this.newTaskInput = new System.Windows.Forms.TextBox();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newTaskLabel = new System.Windows.Forms.Label();
            this.assignProjectBtn = new System.Windows.Forms.Button();
            this.viewProjectBtn = new System.Windows.Forms.Button();
            this.deleteProjectBtn = new System.Windows.Forms.Button();
            this.removeTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectNameInput
            // 
            this.projectNameInput.Location = new System.Drawing.Point(231, 130);
            this.projectNameInput.Name = "projectNameInput";
            this.projectNameInput.Size = new System.Drawing.Size(320, 20);
            this.projectNameInput.TabIndex = 1;
            // 
            // newTaskInput
            // 
            this.newTaskInput.Location = new System.Drawing.Point(231, 214);
            this.newTaskInput.Name = "newTaskInput";
            this.newTaskInput.Size = new System.Drawing.Size(320, 20);
            this.newTaskInput.TabIndex = 2;
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(557, 211);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.addTaskBtn.TabIndex = 3;
            this.addTaskBtn.Text = "Add Task";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(228, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project Name (Case sensitive)";
            // 
            // newTaskLabel
            // 
            this.newTaskLabel.AutoSize = true;
            this.newTaskLabel.ForeColor = System.Drawing.Color.White;
            this.newTaskLabel.Location = new System.Drawing.Point(228, 189);
            this.newTaskLabel.Name = "newTaskLabel";
            this.newTaskLabel.Size = new System.Drawing.Size(31, 13);
            this.newTaskLabel.TabIndex = 6;
            this.newTaskLabel.Text = "Task";
            // 
            // assignProjectBtn
            // 
            this.assignProjectBtn.Location = new System.Drawing.Point(302, 267);
            this.assignProjectBtn.Name = "assignProjectBtn";
            this.assignProjectBtn.Size = new System.Drawing.Size(193, 23);
            this.assignProjectBtn.TabIndex = 7;
            this.assignProjectBtn.Text = "Assign New Project";
            this.assignProjectBtn.UseVisualStyleBackColor = true;
            this.assignProjectBtn.Click += new System.EventHandler(this.assignProjectBtn_Click);
            // 
            // viewProjectBtn
            // 
            this.viewProjectBtn.Location = new System.Drawing.Point(302, 387);
            this.viewProjectBtn.Name = "viewProjectBtn";
            this.viewProjectBtn.Size = new System.Drawing.Size(193, 23);
            this.viewProjectBtn.TabIndex = 8;
            this.viewProjectBtn.Text = "View Projects";
            this.viewProjectBtn.UseVisualStyleBackColor = true;
            this.viewProjectBtn.Click += new System.EventHandler(this.viewProjectBtn_Click);
            // 
            // deleteProjectBtn
            // 
            this.deleteProjectBtn.Location = new System.Drawing.Point(302, 328);
            this.deleteProjectBtn.Name = "deleteProjectBtn";
            this.deleteProjectBtn.Size = new System.Drawing.Size(193, 23);
            this.deleteProjectBtn.TabIndex = 10;
            this.deleteProjectBtn.Text = "Delete Project";
            this.deleteProjectBtn.UseVisualStyleBackColor = true;
            this.deleteProjectBtn.Click += new System.EventHandler(this.deleteProjectBtn_Click);
            // 
            // removeTaskBtn
            // 
            this.removeTaskBtn.Location = new System.Drawing.Point(638, 212);
            this.removeTaskBtn.Name = "removeTaskBtn";
            this.removeTaskBtn.Size = new System.Drawing.Size(89, 23);
            this.removeTaskBtn.TabIndex = 11;
            this.removeTaskBtn.Text = "Remove Task";
            this.removeTaskBtn.UseVisualStyleBackColor = true;
            this.removeTaskBtn.Click += new System.EventHandler(this.removeTaskBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeTaskBtn);
            this.Controls.Add(this.deleteProjectBtn);
            this.Controls.Add(this.viewProjectBtn);
            this.Controls.Add(this.assignProjectBtn);
            this.Controls.Add(this.newTaskLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(this.newTaskInput);
            this.Controls.Add(this.projectNameInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox projectNameInput;
        private System.Windows.Forms.TextBox newTaskInput;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label newTaskLabel;
        private System.Windows.Forms.Button assignProjectBtn;
        private System.Windows.Forms.Button viewProjectBtn;
        private System.Windows.Forms.Button deleteProjectBtn;
        private System.Windows.Forms.Button removeTaskBtn;
    }
}