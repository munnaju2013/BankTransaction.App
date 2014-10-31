using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SundayBank.App
{
    public partial class BankUI : Form
    {
        private Bank aBank;
        private double amount;

        public BankUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aBank = new Bank(accountNumberTextBox.Text,customerNameTextBox.Text);
            MessageBox.Show(@"Created Successfully....");
            accountNumberTextBox.Text = String.Empty;
            customerNameTextBox.Text = String.Empty;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (aBank != null)
            {
                amount = Convert.ToDouble(amountTextBox.Text);
                aBank.Deposit(amount);
                MessageBox.Show(@"Your account has been depositted....");
            }
            else
            {
                MessageBox.Show(@"Please account created first....");
            }
            
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            aBank.Withdraw(amount);
            MessageBox.Show(@"Your account has been withdrawn....");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aBank.GetReport());
        }
    }
}
