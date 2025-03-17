namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.txtUnm = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.Label();
            this.unm = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnm
            // 
            this.txtUnm.AutoSize = true;
            this.txtUnm.Location = new System.Drawing.Point(12, 78);
            this.txtUnm.Name = "txtUnm";
            this.txtUnm.Size = new System.Drawing.Size(83, 20);
            this.txtUnm.TabIndex = 0;
            this.txtUnm.Text = "Username";
            // 
            // txtPwd
            // 
            this.txtPwd.AutoSize = true;
            this.txtPwd.Location = new System.Drawing.Point(12, 114);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(78, 20);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.Text = "Password";
            // 
            // unm
            // 
            this.unm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.unm.Location = new System.Drawing.Point(112, 78);
            this.unm.Name = "unm";
            this.unm.Size = new System.Drawing.Size(315, 26);
            this.unm.TabIndex = 1;
            // 
            // pwd
            // 
            this.pwd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pwd.Location = new System.Drawing.Point(112, 114);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(315, 26);
            this.pwd.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.unm);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUnm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUnm;
        private System.Windows.Forms.Label txtPwd;
        private System.Windows.Forms.TextBox unm;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Button button1;
    }
}

