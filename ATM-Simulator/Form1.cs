using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Class scope Variables
        decimal currentBalance = 0;

        private decimal CheckDeposit(decimal amount)
        {
            decimal max = 200;
            decimal min = 20;
            decimal depositAmount = 0;

            if (depositAmount < min || depositAmount > max)
            {
                MessageBox.Show("Value is incorrect!");
            }
            else
            {
                return depositAmount;
            }
        }


    }
}
