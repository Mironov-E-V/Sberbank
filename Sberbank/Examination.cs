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
    public partial class ExaminationForm : Form
    {
        public ExaminationForm()
        {
            InitializeComponent();
        }
        private void RandomTextLabel_Layout(object sender, LayoutEventArgs e)
        {
            Randomise();
        }

        public void Randomise()
        {
            Random rand = new Random();
            int stringlen = rand.Next(4, 10);
            int randValue;
            string str = "";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {
                randValue = rand.Next(0, 26);
                letter = Convert.ToChar(randValue + 65);
                str = str + letter;
            }
            this.RandomTextLabel.Text = str;
        }

        private void ExaminationButton_Click(object sender, EventArgs e)
        {
            AutorizationForm autorization = new AutorizationForm();
            if (RandomTextBox.Text == RandomTextLabel.Text)
            {
               this.Close();
            }
            else
            {
                Randomise();
            }
        }
    }
}
