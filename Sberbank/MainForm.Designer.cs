namespace Sberbank
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.TransactionButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.InputButton = new System.Windows.Forms.Button();
            this.BalanceButton = new System.Windows.Forms.Button();
            this.UserCabinetButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.ColumnCount = 1;
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopPanel.Controls.Add(this.splitContainer1, 0, 1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.RowCount = 2;
            this.TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.333333F));
            this.TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.66666F));
            this.TopPanel.Size = new System.Drawing.Size(993, 600);
            this.TopPanel.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(7, 50);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Size = new System.Drawing.Size(979, 544);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.HistoryButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ConvertButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TransactionButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.OutputButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.InputButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BalanceButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserCabinetButton, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(172, 544);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.Green;
            this.HistoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.ForeColor = System.Drawing.Color.White;
            this.HistoryButton.Location = new System.Drawing.Point(7, 391);
            this.HistoryButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(158, 65);
            this.HistoryButton.TabIndex = 5;
            this.HistoryButton.Text = "История";
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.Green;
            this.ConvertButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.ForeColor = System.Drawing.Color.White;
            this.ConvertButton.Location = new System.Drawing.Point(7, 314);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(158, 65);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Конвертация валют";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // TransactionButton
            // 
            this.TransactionButton.BackColor = System.Drawing.Color.Green;
            this.TransactionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionButton.ForeColor = System.Drawing.Color.White;
            this.TransactionButton.Location = new System.Drawing.Point(7, 237);
            this.TransactionButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(158, 65);
            this.TransactionButton.TabIndex = 3;
            this.TransactionButton.Text = "Перевод на счет";
            this.TransactionButton.UseVisualStyleBackColor = false;
            this.TransactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.BackColor = System.Drawing.Color.Green;
            this.OutputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputButton.ForeColor = System.Drawing.Color.White;
            this.OutputButton.Location = new System.Drawing.Point(7, 160);
            this.OutputButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(158, 65);
            this.OutputButton.TabIndex = 2;
            this.OutputButton.Text = "Снять с баланса";
            this.OutputButton.UseVisualStyleBackColor = false;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // InputButton
            // 
            this.InputButton.BackColor = System.Drawing.Color.Green;
            this.InputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputButton.ForeColor = System.Drawing.Color.White;
            this.InputButton.Location = new System.Drawing.Point(7, 83);
            this.InputButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(158, 65);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = "Пополнить баланс";
            this.InputButton.UseVisualStyleBackColor = false;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // BalanceButton
            // 
            this.BalanceButton.BackColor = System.Drawing.Color.Green;
            this.BalanceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BalanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalanceButton.ForeColor = System.Drawing.Color.White;
            this.BalanceButton.Location = new System.Drawing.Point(7, 6);
            this.BalanceButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BalanceButton.Name = "BalanceButton";
            this.BalanceButton.Size = new System.Drawing.Size(158, 65);
            this.BalanceButton.TabIndex = 0;
            this.BalanceButton.Text = "Баланс";
            this.BalanceButton.UseVisualStyleBackColor = false;
            this.BalanceButton.Click += new System.EventHandler(this.BalanceButton_Click);
            // 
            // UserCabinetButton
            // 
            this.UserCabinetButton.BackColor = System.Drawing.Color.Green;
            this.UserCabinetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserCabinetButton.ForeColor = System.Drawing.Color.White;
            this.UserCabinetButton.Location = new System.Drawing.Point(3, 465);
            this.UserCabinetButton.Name = "UserCabinetButton";
            this.UserCabinetButton.Size = new System.Drawing.Size(166, 76);
            this.UserCabinetButton.TabIndex = 6;
            this.UserCabinetButton.Text = "Личный кабинет";
            this.UserCabinetButton.UseVisualStyleBackColor = false;
            this.UserCabinetButton.Click += new System.EventHandler(this.UserCabinetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(993, 600);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TopPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TopPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button TransactionButton;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button BalanceButton;
        private System.Windows.Forms.Button UserCabinetButton;
    }
}