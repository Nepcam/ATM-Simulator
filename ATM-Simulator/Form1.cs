using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

        /// <summary>
        /// Checks the deposit value
        /// </summary>
        /// <param name="deposit">The dollar value from the user input</param>
        /// <returns>Returns a booleon value</returns>
        private bool CheckDeposit(decimal deposit)
        {
            decimal max = 200;
            decimal min = 20;

            if (deposit < min || deposit > max)
            {
                MessageBox.Show("Value is incorrect!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal depositAmount = decimal.Parse(textBoxEnterAmount.Text);

                if (CheckDeposit(depositAmount))
                {
                    currentBalance += depositAmount;
                    textBoxDisplayAmount.Text = currentBalance.ToString("c");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckWithdrawal(decimal withdrawal)
        {
            decimal min = 20;
            decimal max = currentBalance;

            if (withdrawal < min || withdrawal > currentBalance)
            {
                MessageBox.Show("Value is incorrect!");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                decimal withdrawAmount = decimal.Parse(textBoxEnterAmount.Text);

                if (CheckWithdrawal(withdrawAmount))
                {
                    currentBalance -= withdrawAmount;
                    textBoxDisplayAmount.Text = currentBalance.ToString("c");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
