using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WiimoteTest
{
    public partial class ConfirmPosition : Form
    {
        int timeRemaining = 1000;
        bool booMessage = false;
        public ConfirmPosition()
        {
            InitializeComponent();
            // countdown.Enabled = true;

        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            if (timeRemaining == 0 && booMessage == false)
            { 
                booMessage = true;
                tmrCountdown.Enabled = false;
                MessageBox.Show("You have run out of time!");
                this.Close();
                   
                }
               
            
            
            else 
                {
                timeRemaining--;
                progTim.Value = timeRemaining;
                // countdown.Enabled = true;
                booMessage = false;
            }
            }
        }
    }


