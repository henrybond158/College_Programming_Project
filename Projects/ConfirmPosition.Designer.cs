namespace WiimoteTest
{
    partial class ConfirmPosition
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
            this.txtInstructions = new System.Windows.Forms.Label();
            this.progTim = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtInstructions
            // 
            this.txtInstructions.AutoSize = true;
            this.txtInstructions.ForeColor = System.Drawing.Color.Lime;
            this.txtInstructions.Location = new System.Drawing.Point(217, 308);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(228, 13);
            this.txtInstructions.TabIndex = 0;
            this.txtInstructions.Text = "Please Hold WiiMote In Position Shown Above";
            // 
            // progTim
            // 
            this.progTim.Location = new System.Drawing.Point(220, 365);
            this.progTim.Maximum = 1000;
            this.progTim.Name = "progTim";
            this.progTim.Size = new System.Drawing.Size(225, 23);
            this.progTim.TabIndex = 1;
            this.progTim.Value = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(217, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Remaining:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(205, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 193);
            this.panel1.TabIndex = 3;
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Enabled = true;
            this.tmrCountdown.Interval = 10;
            this.tmrCountdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // ConfirmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(680, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progTim);
            this.Controls.Add(this.txtInstructions);
            this.Name = "ConfirmPosition";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtInstructions;
        private System.Windows.Forms.ProgressBar progTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrCountdown;
    }
}