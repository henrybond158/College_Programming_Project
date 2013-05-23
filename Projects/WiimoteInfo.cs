// imports APIs from external libraries
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Windows.Forms;
using WiimoteLib;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Security.AccessControl;



namespace WiimoteTest
{   // creates a class WiimoteInfo that inherits from UsesrControl
    public partial class WiimoteInfo : UserControl
    {
        private delegate void UpdateWiimoteStateDelegate(WiimoteChangedEventArgs args);
        private delegate void UpdateExtensionChangedDelegate(WiimoteExtensionChangedEventArgs args);
        bool fileExists = false;
        private Bitmap b = new Bitmap(256, 192, PixelFormat.Format24bppRgb);
        private Graphics g;
        private Wiimote mWiimote;

        public WiimoteInfo()
        {
            InitializeComponent();
            g = Graphics.FromImage(b);
        }

        public WiimoteInfo(Wiimote wm)
            : this()
        {
            mWiimote = wm;
        }

        public void UpdateState(WiimoteChangedEventArgs args)
        {
            BeginInvoke(new UpdateWiimoteStateDelegate(UpdateWiimoteChanged), args);
        }

        public void UpdateExtension(WiimoteExtensionChangedEventArgs args)
        {
            BeginInvoke(new UpdateExtensionChangedDelegate(UpdateExtensionChanged), args);
        }





        private void UpdateWiimoteChanged(WiimoteChangedEventArgs args)
        {
            WiimoteState ws = args.WiimoteState;
            // when certain buttons are checked tick box
            clbButtons.SetItemChecked(0, ws.ButtonState.A);
            clbButtons.SetItemChecked(1, ws.ButtonState.B);
            clbButtons.SetItemChecked(2, ws.ButtonState.Minus);
            clbButtons.SetItemChecked(3, ws.ButtonState.Home);
            clbButtons.SetItemChecked(4, ws.ButtonState.Plus);
            clbButtons.SetItemChecked(5, ws.ButtonState.One);
            clbButtons.SetItemChecked(6, ws.ButtonState.Two);
            clbButtons.SetItemChecked(7, ws.ButtonState.Up);
            clbButtons.SetItemChecked(8, ws.ButtonState.Down);
            clbButtons.SetItemChecked(9, ws.ButtonState.Left);
            clbButtons.SetItemChecked(10, ws.ButtonState.Right);

            // sets the values of the accelerometer to lblAccel.Text
            lblAccel.Text = ws.AccelState.Values.ToString();


            switch (ws.ExtensionType)
            {
                case ExtensionType.Nunchuk:
                    lblChuk.Text = ws.NunchukState.AccelState.Values.ToString();
                    lblChukJoy.Text = ws.NunchukState.Joystick.ToString();
                    chkC.Checked = ws.NunchukState.C;
                    chkZ.Checked = ws.NunchukState.Z;
                    break;


                case ExtensionType.BalanceBoard:
                    if (chkLbs.Checked)
                    {
                        lblBBTL.Text = ws.BalanceBoardState.SensorValuesLb.TopLeft.ToString();
                        lblBBTR.Text = ws.BalanceBoardState.SensorValuesLb.TopRight.ToString();
                        lblBBBL.Text = ws.BalanceBoardState.SensorValuesLb.BottomLeft.ToString();
                        lblBBBR.Text = ws.BalanceBoardState.SensorValuesLb.BottomRight.ToString();
                        lblBBTotal.Text = ws.BalanceBoardState.WeightLb.ToString();
                    }
                    else
                    {
                        lblBBTL.Text = ws.BalanceBoardState.SensorValuesKg.TopLeft.ToString();
                        lblBBTR.Text = ws.BalanceBoardState.SensorValuesKg.TopRight.ToString();
                        lblBBBL.Text = ws.BalanceBoardState.SensorValuesKg.BottomLeft.ToString();
                        lblBBBR.Text = ws.BalanceBoardState.SensorValuesKg.BottomRight.ToString();
                        lblBBTotal.Text = ws.BalanceBoardState.WeightKg.ToString();
                    }
                    lblCOG.Text = ws.BalanceBoardState.CenterOfGravity.ToString();
                    break;
            }

            g.Clear(Color.Black);

            pbBattery.Value = (ws.Battery > 0xc8 ? 0xc8 : (int)ws.Battery);
            lblBattery.Text = ws.Battery.ToString();
            lblDevicePath.Text = "Device Path: " + mWiimote.HIDDevicePath;
        }

        private void UpdateIR(IRSensor irSensor, Label lblNorm, Label lblRaw, CheckBox chkFound, Color color)
        {
            chkFound.Checked = irSensor.Found;

            if (irSensor.Found)
            {
                lblNorm.Text = irSensor.Position.ToString() + ", " + irSensor.Size;
                lblRaw.Text = irSensor.RawPosition.ToString();
                g.DrawEllipse(new Pen(color), (int)(irSensor.RawPosition.X / 4), (int)(irSensor.RawPosition.Y / 4),
                             irSensor.Size + 1, irSensor.Size + 1);
            }
        }

        private void UpdateExtensionChanged(WiimoteExtensionChangedEventArgs args)
        {
            chkExtension.Text = args.ExtensionType.ToString();
            chkExtension.Checked = args.Inserted;
        }

        public Wiimote Wiimote
        {
            set { mWiimote = value; }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string thefile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar + "users.txt";
            fileExists = File.Exists(thefile);
            using (TextReader tr = File.OpenText(thefile))
            {
                
                string strLine = string.Empty;
                string[] arrColumn = null;
                string[,] arrColumns = new string[3,3];
                bool booLogin = false;
                int randomInt = 0;
               
                while ((strLine = tr.ReadLine()) != null)
                {

                    arrColumn = strLine.Split(',');
                    for (int x = 0; x <= 2; x++) { arrColumns[randomInt, x] = arrColumn[x]; }
                    randomInt++;
                }
                int lengthA = arrColumns.Length;
                for (int x = 0; x <= 2; x++)
                {
                           if (usrName.Text == arrColumns[x,0] && usrPswd.Text == arrColumns[x,1])
                             {
                                 booLogin = true;
                                 if (MessageBox.Show("Continue", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                 {
                                     ConfirmPosition form = new ConfirmPosition();
                                     form.ShowDialog();
        


                                 }
                                 else
                                 {
                                     MessageBox.Show("You pressed cancel, you failed");
                                 }
                             }
                   
                         }
                            if (booLogin == false)
                         {
                             MessageBox.Show("User name or Password Was Wrong");

                         }
                      }
            
                         
                    }
                
                
            






        private void Register_Click(object sender, EventArgs e)
        {
            string thefile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar + "users.txt";
            fileExists = File.Exists(thefile);

            if (fileExists)
            {


                string loginData = Environment.NewLine + usrName.Text + "," + usrPswd.Text + ",0";
                MessageBox.Show("you have succesffuly registered, please wait for admin to accept you");
                File.AppendAllText(thefile, loginData);
            }


            else
            {


                MessageBox.Show("User Database does not exist {0}", Path.GetDirectoryName(thefile));

                Console.WriteLine("the Dir name is {0}", Path.GetDirectoryName(thefile));

            }
        }
    }
}


       
        
    
  
        

          

   


        
         
    
