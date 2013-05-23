Imports Microsoft.VisualBasic
Imports System
Namespace WiimoteTest
	Partial Public Class WiimoteInfo
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.groupBox8 = New System.Windows.Forms.GroupBox()
            Me.clbButtons = New System.Windows.Forms.CheckedListBox()
            Me.pbIR = New System.Windows.Forms.PictureBox()
            Me.groupBox4 = New System.Windows.Forms.GroupBox()
            Me.pbBattery = New System.Windows.Forms.ProgressBar()
            Me.lblBattery = New System.Windows.Forms.Label()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.chkLED2 = New System.Windows.Forms.CheckBox()
            Me.chkLED4 = New System.Windows.Forms.CheckBox()
            Me.chkLED3 = New System.Windows.Forms.CheckBox()
            Me.chkLED1 = New System.Windows.Forms.CheckBox()
            Me.chkRumble = New System.Windows.Forms.CheckBox()
            Me.chkZ = New System.Windows.Forms.CheckBox()
            Me.chkC = New System.Windows.Forms.CheckBox()
            Me.lblChuk = New System.Windows.Forms.Label()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblChukJoy = New System.Windows.Forms.Label()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblAccel = New System.Windows.Forms.Label()
            Me.chkExtension = New System.Windows.Forms.CheckBox()
            Me.groupBox9 = New System.Windows.Forms.GroupBox()
            Me.lblCOG = New System.Windows.Forms.Label()
            Me.chkLbs = New System.Windows.Forms.CheckBox()
            Me.lblBBBR = New System.Windows.Forms.Label()
            Me.lblBBTR = New System.Windows.Forms.Label()
            Me.lblBBBL = New System.Windows.Forms.Label()
            Me.lblBBTotal = New System.Windows.Forms.Label()
            Me.lblBBTL = New System.Windows.Forms.Label()
            Me.lblDevicePath = New System.Windows.Forms.Label()
            Me.lblBoo = New System.Windows.Forms.Label()
            Me.groupBox8.SuspendLayout()
            CType(Me.pbIR, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox4.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.groupBox9.SuspendLayout()
            Me.SuspendLayout()
            '
            'groupBox8
            '
            Me.groupBox8.Controls.Add(Me.clbButtons)
            Me.groupBox8.Location = New System.Drawing.Point(0, 0)
            Me.groupBox8.Name = "groupBox8"
            Me.groupBox8.Size = New System.Drawing.Size(72, 220)
            Me.groupBox8.TabIndex = 37
            Me.groupBox8.TabStop = False
            Me.groupBox8.Text = "Wiimote"
            '
            'clbButtons
            '
            Me.clbButtons.FormattingEnabled = True
            Me.clbButtons.Items.AddRange(New Object() {"A", "B", "-", "Home", "+", "1", "2", "Up", "Down", "Left", "Right"})
            Me.clbButtons.Location = New System.Drawing.Point(8, 16)
            Me.clbButtons.Name = "clbButtons"
            Me.clbButtons.Size = New System.Drawing.Size(56, 184)
            Me.clbButtons.TabIndex = 1
            '
            'pbIR
            '
            Me.pbIR.Location = New System.Drawing.Point(4, 248)
            Me.pbIR.Name = "pbIR"
            Me.pbIR.Size = New System.Drawing.Size(256, 192)
            Me.pbIR.TabIndex = 28
            Me.pbIR.TabStop = False
            '
            'groupBox4
            '
            Me.groupBox4.Controls.Add(Me.pbBattery)
            Me.groupBox4.Controls.Add(Me.lblBattery)
            Me.groupBox4.Location = New System.Drawing.Point(272, 388)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Size = New System.Drawing.Size(176, 52)
            Me.groupBox4.TabIndex = 33
            Me.groupBox4.TabStop = False
            Me.groupBox4.Text = "Battery"
            '
            'pbBattery
            '
            Me.pbBattery.Location = New System.Drawing.Point(8, 20)
            Me.pbBattery.Maximum = 200
            Me.pbBattery.Name = "pbBattery"
            Me.pbBattery.Size = New System.Drawing.Size(128, 23)
            Me.pbBattery.Step = 1
            Me.pbBattery.TabIndex = 6
            '
            'lblBattery
            '
            Me.lblBattery.AutoSize = True
            Me.lblBattery.Location = New System.Drawing.Point(140, 24)
            Me.lblBattery.Name = "lblBattery"
            Me.lblBattery.Size = New System.Drawing.Size(35, 13)
            Me.lblBattery.TabIndex = 9
            Me.lblBattery.Text = "label1"
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.chkLED2)
            Me.groupBox3.Controls.Add(Me.chkLED4)
            Me.groupBox3.Controls.Add(Me.chkLED3)
            Me.groupBox3.Controls.Add(Me.chkLED1)
            Me.groupBox3.Controls.Add(Me.chkRumble)
            Me.groupBox3.Location = New System.Drawing.Point(264, 248)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(96, 120)
            Me.groupBox3.TabIndex = 32
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Outputs"
            '
            'chkLED2
            '
            Me.chkLED2.AutoSize = True
            Me.chkLED2.Location = New System.Drawing.Point(8, 36)
            Me.chkLED2.Name = "chkLED2"
            Me.chkLED2.Size = New System.Drawing.Size(53, 17)
            Me.chkLED2.TabIndex = 3
            Me.chkLED2.Text = "LED2"
            Me.chkLED2.UseVisualStyleBackColor = True
            '
            'chkLED4
            '
            Me.chkLED4.AutoSize = True
            Me.chkLED4.Location = New System.Drawing.Point(8, 76)
            Me.chkLED4.Name = "chkLED4"
            Me.chkLED4.Size = New System.Drawing.Size(53, 17)
            Me.chkLED4.TabIndex = 3
            Me.chkLED4.Text = "LED4"
            Me.chkLED4.UseVisualStyleBackColor = True
            '
            'chkLED3
            '
            Me.chkLED3.AutoSize = True
            Me.chkLED3.Location = New System.Drawing.Point(8, 56)
            Me.chkLED3.Name = "chkLED3"
            Me.chkLED3.Size = New System.Drawing.Size(53, 17)
            Me.chkLED3.TabIndex = 3
            Me.chkLED3.Text = "LED3"
            Me.chkLED3.UseVisualStyleBackColor = True
            '
            'chkLED1
            '
            Me.chkLED1.AutoSize = True
            Me.chkLED1.Location = New System.Drawing.Point(8, 16)
            Me.chkLED1.Name = "chkLED1"
            Me.chkLED1.Size = New System.Drawing.Size(53, 17)
            Me.chkLED1.TabIndex = 3
            Me.chkLED1.Text = "LED1"
            Me.chkLED1.UseVisualStyleBackColor = True
            '
            'chkRumble
            '
            Me.chkRumble.AutoSize = True
            Me.chkRumble.Location = New System.Drawing.Point(8, 96)
            Me.chkRumble.Name = "chkRumble"
            Me.chkRumble.Size = New System.Drawing.Size(62, 17)
            Me.chkRumble.TabIndex = 4
            Me.chkRumble.Text = "Rumble"
            Me.chkRumble.UseVisualStyleBackColor = True
            '
            'chkZ
            '
            Me.chkZ.AutoSize = True
            Me.chkZ.Location = New System.Drawing.Point(8, 112)
            Me.chkZ.Name = "chkZ"
            Me.chkZ.Size = New System.Drawing.Size(33, 17)
            Me.chkZ.TabIndex = 17
            Me.chkZ.Text = "Z"
            Me.chkZ.UseVisualStyleBackColor = True
            '
            'chkC
            '
            Me.chkC.AutoSize = True
            Me.chkC.Location = New System.Drawing.Point(8, 92)
            Me.chkC.Name = "chkC"
            Me.chkC.Size = New System.Drawing.Size(33, 17)
            Me.chkC.TabIndex = 17
            Me.chkC.Text = "C"
            Me.chkC.UseVisualStyleBackColor = True
            '
            'lblChuk
            '
            Me.lblChuk.Location = New System.Drawing.Point(8, 20)
            Me.lblChuk.Name = "lblChuk"
            Me.lblChuk.Size = New System.Drawing.Size(92, 40)
            Me.lblChuk.TabIndex = 13
            Me.lblChuk.Text = "Accel Values"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.chkZ)
            Me.groupBox2.Controls.Add(Me.chkC)
            Me.groupBox2.Controls.Add(Me.lblChuk)
            Me.groupBox2.Controls.Add(Me.lblChukJoy)
            Me.groupBox2.Location = New System.Drawing.Point(76, 76)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(104, 136)
            Me.groupBox2.TabIndex = 31
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Nunchuk"
            '
            'lblChukJoy
            '
            Me.lblChukJoy.Location = New System.Drawing.Point(8, 64)
            Me.lblChukJoy.Name = "lblChukJoy"
            Me.lblChukJoy.Size = New System.Drawing.Size(92, 28)
            Me.lblChukJoy.TabIndex = 16
            Me.lblChukJoy.Text = "Joystick Values"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.lblAccel)
            Me.groupBox1.Location = New System.Drawing.Point(76, 0)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(104, 72)
            Me.groupBox1.TabIndex = 30
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Wiimote Accel"
            '
            'lblAccel
            '
            Me.lblAccel.Location = New System.Drawing.Point(8, 20)
            Me.lblAccel.Name = "lblAccel"
            Me.lblAccel.Size = New System.Drawing.Size(88, 48)
            Me.lblAccel.TabIndex = 2
            Me.lblAccel.Text = "Accel Values"
            '
            'chkExtension
            '
            Me.chkExtension.AutoSize = True
            Me.chkExtension.Location = New System.Drawing.Point(4, 224)
            Me.chkExtension.Name = "chkExtension"
            Me.chkExtension.Size = New System.Drawing.Size(52, 17)
            Me.chkExtension.TabIndex = 29
            Me.chkExtension.Text = "None"
            Me.chkExtension.UseVisualStyleBackColor = True
            '
            'groupBox9
            '
            Me.groupBox9.Controls.Add(Me.lblCOG)
            Me.groupBox9.Controls.Add(Me.chkLbs)
            Me.groupBox9.Controls.Add(Me.lblBBBR)
            Me.groupBox9.Controls.Add(Me.lblBBTR)
            Me.groupBox9.Controls.Add(Me.lblBBBL)
            Me.groupBox9.Controls.Add(Me.lblBBTotal)
            Me.groupBox9.Controls.Add(Me.lblBBTL)
            Me.groupBox9.Location = New System.Drawing.Point(557, 328)
            Me.groupBox9.Name = "groupBox9"
            Me.groupBox9.Size = New System.Drawing.Size(136, 112)
            Me.groupBox9.TabIndex = 38
            Me.groupBox9.TabStop = False
            Me.groupBox9.Text = "Balance Board"
            '
            'lblCOG
            '
            Me.lblCOG.AutoSize = True
            Me.lblCOG.Location = New System.Drawing.Point(8, 92)
            Me.lblCOG.Name = "lblCOG"
            Me.lblCOG.Size = New System.Drawing.Size(30, 13)
            Me.lblCOG.TabIndex = 2
            Me.lblCOG.Text = "COG"
            '
            'chkLbs
            '
            Me.chkLbs.AutoSize = True
            Me.chkLbs.Location = New System.Drawing.Point(28, 68)
            Me.chkLbs.Name = "chkLbs"
            Me.chkLbs.Size = New System.Drawing.Size(62, 17)
            Me.chkLbs.TabIndex = 1
            Me.chkLbs.Text = "Pounds"
            Me.chkLbs.UseVisualStyleBackColor = True
            '
            'lblBBBR
            '
            Me.lblBBBR.AutoSize = True
            Me.lblBBBR.Location = New System.Drawing.Point(76, 48)
            Me.lblBBBR.Name = "lblBBBR"
            Me.lblBBBR.Size = New System.Drawing.Size(22, 13)
            Me.lblBBBR.TabIndex = 0
            Me.lblBBBR.Text = "BR"
            '
            'lblBBTR
            '
            Me.lblBBTR.AutoSize = True
            Me.lblBBTR.Location = New System.Drawing.Point(76, 16)
            Me.lblBBTR.Name = "lblBBTR"
            Me.lblBBTR.Size = New System.Drawing.Size(22, 13)
            Me.lblBBTR.TabIndex = 0
            Me.lblBBTR.Text = "TR"
            '
            'lblBBBL
            '
            Me.lblBBBL.AutoSize = True
            Me.lblBBBL.Location = New System.Drawing.Point(8, 48)
            Me.lblBBBL.Name = "lblBBBL"
            Me.lblBBBL.Size = New System.Drawing.Size(20, 13)
            Me.lblBBBL.TabIndex = 0
            Me.lblBBBL.Text = "BL"
            '
            'lblBBTotal
            '
            Me.lblBBTotal.AutoSize = True
            Me.lblBBTotal.Location = New System.Drawing.Point(36, 32)
            Me.lblBBTotal.Name = "lblBBTotal"
            Me.lblBBTotal.Size = New System.Drawing.Size(31, 13)
            Me.lblBBTotal.TabIndex = 0
            Me.lblBBTotal.Text = "Total"
            '
            'lblBBTL
            '
            Me.lblBBTL.AutoSize = True
            Me.lblBBTL.Location = New System.Drawing.Point(8, 16)
            Me.lblBBTL.Name = "lblBBTL"
            Me.lblBBTL.Size = New System.Drawing.Size(20, 13)
            Me.lblBBTL.TabIndex = 0
            Me.lblBBTL.Text = "TL"
            '
            'lblDevicePath
            '
            Me.lblDevicePath.AutoSize = True
            Me.lblDevicePath.Location = New System.Drawing.Point(8, 444)
            Me.lblDevicePath.Name = "lblDevicePath"
            Me.lblDevicePath.Size = New System.Drawing.Size(63, 13)
            Me.lblDevicePath.TabIndex = 39
            Me.lblDevicePath.Text = "DevicePath"
            '
            'lblBoo
            '
            Me.lblBoo.AutoSize = True
            Me.lblBoo.Location = New System.Drawing.Point(217, 48)
            Me.lblBoo.Name = "lblBoo"
            Me.lblBoo.Size = New System.Drawing.Size(69, 13)
            Me.lblBoo.TabIndex = 40
            Me.lblBoo.Text = "True or False"
            '
            'WiimoteInfo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.lblBoo)
            Me.Controls.Add(Me.lblDevicePath)
            Me.Controls.Add(Me.groupBox9)
            Me.Controls.Add(Me.groupBox8)
            Me.Controls.Add(Me.pbIR)
            Me.Controls.Add(Me.groupBox4)
            Me.Controls.Add(Me.groupBox3)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.chkExtension)
            Me.Name = "WiimoteInfo"
            Me.Size = New System.Drawing.Size(696, 464)
            Me.groupBox8.ResumeLayout(False)
            CType(Me.pbIR, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox4.ResumeLayout(False)
            Me.groupBox4.PerformLayout()
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox3.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox9.ResumeLayout(False)
            Me.groupBox9.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Public groupBox8 As System.Windows.Forms.GroupBox
		Public clbButtons As System.Windows.Forms.CheckedListBox
        Public pbIR As System.Windows.Forms.PictureBox
        Public groupBox4 As System.Windows.Forms.GroupBox
		Public pbBattery As System.Windows.Forms.ProgressBar
		Public lblBattery As System.Windows.Forms.Label
		Public groupBox3 As System.Windows.Forms.GroupBox
		Public WithEvents chkLED2 As System.Windows.Forms.CheckBox
		Public WithEvents chkLED4 As System.Windows.Forms.CheckBox
		Public WithEvents chkLED3 As System.Windows.Forms.CheckBox
		Public WithEvents chkLED1 As System.Windows.Forms.CheckBox
		Public WithEvents chkRumble As System.Windows.Forms.CheckBox
		Public chkZ As System.Windows.Forms.CheckBox
		Public chkC As System.Windows.Forms.CheckBox
		Public lblChuk As System.Windows.Forms.Label
		Public groupBox2 As System.Windows.Forms.GroupBox
		Public lblChukJoy As System.Windows.Forms.Label
		Public groupBox1 As System.Windows.Forms.GroupBox
		Public lblAccel As System.Windows.Forms.Label
		Public chkExtension As System.Windows.Forms.CheckBox
		Private groupBox9 As System.Windows.Forms.GroupBox
		Private chkLbs As System.Windows.Forms.CheckBox
		Private lblBBBR As System.Windows.Forms.Label
		Private lblBBTR As System.Windows.Forms.Label
		Private lblBBBL As System.Windows.Forms.Label
		Private lblBBTotal As System.Windows.Forms.Label
		Private lblBBTL As System.Windows.Forms.Label
		Private lblCOG As System.Windows.Forms.Label
        Private lblDevicePath As System.Windows.Forms.Label
        Friend WithEvents lblBoo As System.Windows.Forms.Label

	End Class
End Namespace
