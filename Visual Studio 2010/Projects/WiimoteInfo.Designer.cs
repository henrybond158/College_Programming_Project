namespace WiimoteTest
{
	partial class WiimoteInfo
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.clbButtons = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbBattery = new System.Windows.Forms.ProgressBar();
            this.lblBattery = new System.Windows.Forms.Label();
            this.chkZ = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.lblChuk = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblChukJoy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAccel = new System.Windows.Forms.Label();
            this.chkExtension = new System.Windows.Forms.CheckBox();
            this.lblDevicePath = new System.Windows.Forms.Label();
            this.lblBBTL = new System.Windows.Forms.Label();
            this.lblBBTotal = new System.Windows.Forms.Label();
            this.lblBBBL = new System.Windows.Forms.Label();
            this.lblBBTR = new System.Windows.Forms.Label();
            this.lblBBBR = new System.Windows.Forms.Label();
            this.chkLbs = new System.Windows.Forms.CheckBox();
            this.lblCOG = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.usrName = new System.Windows.Forms.TextBox();
            this.usrPswd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.clbButtons);
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(72, 220);
            this.groupBox8.TabIndex = 37;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Wiimote";
            // 
            // clbButtons
            // 
            this.clbButtons.FormattingEnabled = true;
            this.clbButtons.Items.AddRange(new object[] {
            "A",
            "B",
            "-",
            "Home",
            "+",
            "1",
            "2",
            "Up",
            "Down",
            "Left",
            "Right"});
            this.clbButtons.Location = new System.Drawing.Point(8, 16);
            this.clbButtons.Name = "clbButtons";
            this.clbButtons.Size = new System.Drawing.Size(56, 184);
            this.clbButtons.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbBattery);
            this.groupBox4.Controls.Add(this.lblBattery);
            this.groupBox4.Location = new System.Drawing.Point(418, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 52);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Battery";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // pbBattery
            // 
            this.pbBattery.Location = new System.Drawing.Point(8, 20);
            this.pbBattery.Maximum = 200;
            this.pbBattery.Name = "pbBattery";
            this.pbBattery.Size = new System.Drawing.Size(128, 23);
            this.pbBattery.Step = 1;
            this.pbBattery.TabIndex = 6;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(140, 24);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(35, 13);
            this.lblBattery.TabIndex = 9;
            this.lblBattery.Text = "label1";
            // 
            // chkZ
            // 
            this.chkZ.AutoSize = true;
            this.chkZ.Location = new System.Drawing.Point(8, 112);
            this.chkZ.Name = "chkZ";
            this.chkZ.Size = new System.Drawing.Size(33, 17);
            this.chkZ.TabIndex = 17;
            this.chkZ.Text = "Z";
            this.chkZ.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(8, 92);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(33, 17);
            this.chkC.TabIndex = 17;
            this.chkC.Text = "C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // lblChuk
            // 
            this.lblChuk.Location = new System.Drawing.Point(8, 20);
            this.lblChuk.Name = "lblChuk";
            this.lblChuk.Size = new System.Drawing.Size(92, 40);
            this.lblChuk.TabIndex = 13;
            this.lblChuk.Text = "Accel Values";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkZ);
            this.groupBox2.Controls.Add(this.chkC);
            this.groupBox2.Controls.Add(this.lblChuk);
            this.groupBox2.Controls.Add(this.lblChukJoy);
            this.groupBox2.Location = new System.Drawing.Point(490, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 136);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nunchuk";
            // 
            // lblChukJoy
            // 
            this.lblChukJoy.Location = new System.Drawing.Point(8, 64);
            this.lblChukJoy.Name = "lblChukJoy";
            this.lblChukJoy.Size = new System.Drawing.Size(92, 28);
            this.lblChukJoy.TabIndex = 16;
            this.lblChukJoy.Text = "Joystick Values";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAccel);
            this.groupBox1.Location = new System.Drawing.Point(490, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 72);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wiimote Accel";
            // 
            // lblAccel
            // 
            this.lblAccel.Location = new System.Drawing.Point(8, 20);
            this.lblAccel.Name = "lblAccel";
            this.lblAccel.Size = new System.Drawing.Size(88, 48);
            this.lblAccel.TabIndex = 2;
            this.lblAccel.Text = "Accel Values";
            // 
            // chkExtension
            // 
            this.chkExtension.AutoSize = true;
            this.chkExtension.Location = new System.Drawing.Point(4, 224);
            this.chkExtension.Name = "chkExtension";
            this.chkExtension.Size = new System.Drawing.Size(52, 17);
            this.chkExtension.TabIndex = 29;
            this.chkExtension.Text = "None";
            this.chkExtension.UseVisualStyleBackColor = true;
            // 
            // lblDevicePath
            // 
            this.lblDevicePath.AutoSize = true;
            this.lblDevicePath.Location = new System.Drawing.Point(8, 444);
            this.lblDevicePath.Name = "lblDevicePath";
            this.lblDevicePath.Size = new System.Drawing.Size(63, 13);
            this.lblDevicePath.TabIndex = 39;
            this.lblDevicePath.Text = "DevicePath";
            // 
            // lblBBTL
            // 
            this.lblBBTL.AutoSize = true;
            this.lblBBTL.Location = new System.Drawing.Point(8, 16);
            this.lblBBTL.Name = "lblBBTL";
            this.lblBBTL.Size = new System.Drawing.Size(20, 13);
            this.lblBBTL.TabIndex = 0;
            this.lblBBTL.Text = "TL";
            // 
            // lblBBTotal
            // 
            this.lblBBTotal.AutoSize = true;
            this.lblBBTotal.Location = new System.Drawing.Point(36, 32);
            this.lblBBTotal.Name = "lblBBTotal";
            this.lblBBTotal.Size = new System.Drawing.Size(31, 13);
            this.lblBBTotal.TabIndex = 0;
            this.lblBBTotal.Text = "Total";
            // 
            // lblBBBL
            // 
            this.lblBBBL.AutoSize = true;
            this.lblBBBL.Location = new System.Drawing.Point(8, 48);
            this.lblBBBL.Name = "lblBBBL";
            this.lblBBBL.Size = new System.Drawing.Size(20, 13);
            this.lblBBBL.TabIndex = 0;
            this.lblBBBL.Text = "BL";
            // 
            // lblBBTR
            // 
            this.lblBBTR.AutoSize = true;
            this.lblBBTR.Location = new System.Drawing.Point(76, 16);
            this.lblBBTR.Name = "lblBBTR";
            this.lblBBTR.Size = new System.Drawing.Size(22, 13);
            this.lblBBTR.TabIndex = 0;
            this.lblBBTR.Text = "TR";
            // 
            // lblBBBR
            // 
            this.lblBBBR.AutoSize = true;
            this.lblBBBR.Location = new System.Drawing.Point(76, 48);
            this.lblBBBR.Name = "lblBBBR";
            this.lblBBBR.Size = new System.Drawing.Size(22, 13);
            this.lblBBBR.TabIndex = 0;
            this.lblBBBR.Text = "BR";
            // 
            // chkLbs
            // 
            this.chkLbs.AutoSize = true;
            this.chkLbs.Location = new System.Drawing.Point(28, 68);
            this.chkLbs.Name = "chkLbs";
            this.chkLbs.Size = new System.Drawing.Size(62, 17);
            this.chkLbs.TabIndex = 1;
            this.chkLbs.Text = "Pounds";
            this.chkLbs.UseVisualStyleBackColor = true;
            // 
            // lblCOG
            // 
            this.lblCOG.AutoSize = true;
            this.lblCOG.Location = new System.Drawing.Point(8, 92);
            this.lblCOG.Name = "lblCOG";
            this.lblCOG.Size = new System.Drawing.Size(30, 13);
            this.lblCOG.TabIndex = 2;
            this.lblCOG.Text = "COG";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblCOG);
            this.groupBox9.Controls.Add(this.chkLbs);
            this.groupBox9.Controls.Add(this.lblBBBR);
            this.groupBox9.Controls.Add(this.lblBBTR);
            this.groupBox9.Controls.Add(this.lblBBBL);
            this.groupBox9.Controls.Add(this.lblBBTotal);
            this.groupBox9.Controls.Add(this.lblBBTL);
            this.groupBox9.Location = new System.Drawing.Point(556, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(136, 112);
            this.groupBox9.TabIndex = 38;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Balance Board";
            // 
            // usrName
            // 
            this.usrName.BackColor = System.Drawing.Color.Lime;
            this.usrName.Location = new System.Drawing.Point(227, 264);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(100, 20);
            this.usrName.TabIndex = 40;
            // 
            // usrPswd
            // 
            this.usrPswd.BackColor = System.Drawing.Color.Lime;
            this.usrPswd.Location = new System.Drawing.Point(227, 290);
            this.usrPswd.Name = "usrPswd";
            this.usrPswd.PasswordChar = '*';
            this.usrPswd.Size = new System.Drawing.Size(100, 20);
            this.usrPswd.TabIndex = 41;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(206, 316);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 42;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(287, 316);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 43;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // WiimoteInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.Controls.Add(this.Register);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.usrPswd);
            this.Controls.Add(this.usrName);
            this.Controls.Add(this.lblDevicePath);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkExtension);
            this.Name = "WiimoteInfo";
            this.Size = new System.Drawing.Size(696, 464);
            this.groupBox8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.CheckedListBox clbButtons;
		public System.Windows.Forms.GroupBox groupBox4;
		public System.Windows.Forms.ProgressBar pbBattery;
        public System.Windows.Forms.Label lblBattery;
		public System.Windows.Forms.CheckBox chkZ;
		public System.Windows.Forms.CheckBox chkC;
		public System.Windows.Forms.Label lblChuk;
		public System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.Label lblChukJoy;
		public System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.Label lblAccel;
        public System.Windows.Forms.CheckBox chkExtension;
        private System.Windows.Forms.Label lblDevicePath;
        private System.Windows.Forms.Label lblBBTL;
        private System.Windows.Forms.Label lblBBTotal;
        private System.Windows.Forms.Label lblBBBL;
        private System.Windows.Forms.Label lblBBTR;
        private System.Windows.Forms.Label lblBBBR;
        private System.Windows.Forms.CheckBox chkLbs;
        private System.Windows.Forms.Label lblCOG;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox usrName;
        private System.Windows.Forms.TextBox usrPswd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button Register;

	}
}
