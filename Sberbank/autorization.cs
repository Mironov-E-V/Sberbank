using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sberbank
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            if (NumberCardTextBox.Text == "1111-1111-1111-1111" && PinCodeTextBox.Text == "1111")
            {
                MainForm autorization = new MainForm(this);
                this.Hide();
                this.NumberCardTextBox.Text = "";
                this.PinCodeTextBox.Text = "";
                autorization.ShowDialog();
            }
            else
            {
                ExaminationForm examination= new ExaminationForm();
                this.Hide();
                this.PinCodeTextBox.Text = "";
                examination.ShowDialog();
                this.Show();
            }
        }
    }
}
