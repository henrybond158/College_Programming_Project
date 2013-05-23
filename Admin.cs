using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WiimoteTest
{
    public partial class Admin : Form
    {
        public Admin()
     
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPasswd_TextChanged(object sender, EventArgs e)
        {
            // if text is empty
            if (String.IsNullOrEmpty(txtNewPasswd.Text))
            //set default message 
            {
                //sets default message
                txtNewPasswd.Text = "Enter New Password Here";
                txtNewPasswd.PasswordChar = Char.MinValue;
            }


            if (txtNewPasswd.PasswordChar.Equals(Char.MinValue) && txtNewPasswd.Text.Equals("Enter New Password Here").Equals(false))
            {
                txtNewPasswd.Text = txtNewPasswd.Text[0].ToString();
                txtNewPasswd.SelectionStart = 1;

            }

        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
           {
               bool fileExists = false;
           
        
       
            string thefile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar + "users.txt";
            fileExists = File.Exists(thefile);
                if (fileExists)
                {
}


                else
                {


                    MessageBox.Show("User Database does not exist {0}", Path.GetDirectoryName(thefile));

                    Console.WriteLine("the Dir name is {0}", Path.GetDirectoryName(thefile));

                }
            
        }
    }
}