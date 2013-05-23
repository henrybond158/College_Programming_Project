namespace WiimoteTest
{
    partial class Admin
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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.txtNewPasswd = new System.Windows.Forms.TextBox();
            this.btnChangePswd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelUsr = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(257, 41);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(120, 95);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // txtNewPasswd
            // 
            this.txtNewPasswd.Location = new System.Drawing.Point(257, 157);
            this.txtNewPasswd.Name = "txtNewPasswd";
            this.txtNewPasswd.Size = new System.Drawing.Size(120, 20);
            this.txtNewPasswd.TabIndex = 1;
            this.txtNewPasswd.Tag = "";
            this.txtNewPasswd.TextChanged += new System.EventHandler(this.txtNewPasswd_TextChanged);
            // 
            // btnChangePswd
            // 
            this.btnChangePswd.Location = new System.Drawing.Point(257, 199);
            this.btnChangePswd.Name = "btnChangePswd";
            this.btnChangePswd.Size = new System.Drawing.Size(120, 23);
            this.btnChangePswd.TabIndex = 2;
            this.btnChangePswd.Text = "Change Password";
            this.btnChangePswd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Authorise User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelUsr
            // 
            this.btnDelUsr.Location = new System.Drawing.Point(257, 292);
            this.btnDelUsr.Name = "btnDelUsr";
            this.btnDelUsr.Size = new System.Drawing.Size(120, 23);
            this.btnDelUsr.TabIndex = 4;
            this.btnDelUsr.Text = "Delete User";
            this.btnDelUsr.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(257, 322);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Check To Confirm Deletion";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(680, 425);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnDelUsr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangePswd);
            this.Controls.Add(this.txtNewPasswd);
            this.Controls.Add(this.lstUsers);
            this.Name = "Admin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TextBox txtNewPasswd;
        private System.Windows.Forms.Button btnChangePswd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelUsr;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}