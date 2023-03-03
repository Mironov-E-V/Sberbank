using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sberbank.OpeningWindows
{
    public partial class BalanceControl : UserControl
    {
        public BalanceControl()
        {
            InitializeComponent();
            moneyvalue();
        }
        public void moneyvalue()
        {
            try
            {
                string str = @"Balance.txt";
                BalanceValueLabel.Text = str;
                using (StreamReader money = new StreamReader(BalanceValueLabel.Text))
                {
                    BalanceValueLabel.Text = money.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            moneyvalue();
        }
    }
}
