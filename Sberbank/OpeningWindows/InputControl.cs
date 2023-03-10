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
    public partial class InputControl : UserControl
    {
        public InputControl()
        {
            InitializeComponent();
        }

        public void InputBalanceButton_Click(object sender, EventArgs e)
        {
            string str = @"Balance.txt";
            string input = str;
            int coin = 0;
            try
            {
                using (StreamReader money = new StreamReader(input))
                {
                    input = money.ReadToEnd();
                    coin = int.Parse(input);
                    int incoin = int.Parse(InputBalanceBox.Text);
                    coin += incoin;
                }
                using (StreamWriter Inmoney = new StreamWriter(str))
                {
                   
                   Inmoney.WriteLine(coin);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
