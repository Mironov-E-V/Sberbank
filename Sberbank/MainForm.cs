using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sberbank
{
    public partial class MainForm : Form
    {
        protected AutorizationForm _authorization;
        protected Dictionary<string, UserControl> windows;
        public MainForm(AutorizationForm autorazation)
        {
            InitializeComponent();
            _authorization = autorazation;
            loadData();
        }
        private void loadData()
        {
            windows = new Dictionary<string, UserControl>()
            {
                {"Balance", new OpeningWindows.BalanceControl()},
                {"Convert", new OpeningWindows.ConvertControl()},
                {"History", new OpeningWindows.HistoryControl()},
                {"Input", new OpeningWindows.InputControl()},
                {"Output", new OpeningWindows.OutputControl()},
                {"Transactio", new OpeningWindows.TransactionControl()},
                {"UserCabinet", new OpeningWindows.UserCabinetControl()},
            };
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var reply = MessageBox.Show("Вернуться к вводу данных?", "Закрытие приложения", MessageBoxButtons.YesNoCancel);
            if (reply==DialogResult.Yes)
            {
                _authorization.Show();
            }
            else if (reply==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                _authorization.Close();

            }
        }
        private void setupControlsInPanel(UserControl userControl)
        {
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void BalanceButton_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(windows["Balance"]);
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(windows["Input"]);
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(windows["Output"]);
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(windows["Transactio"]);
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(windows["Convert"]);
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(windows["History"]);
        }

        private void UserCabinetButton_Click(object sender, EventArgs e)
        {
            setupControlsInPanel(windows["UserCabinet"]);
        }
    }
}
