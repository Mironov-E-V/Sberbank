namespace Sberbank.OpeningWindows
{
    partial class BalanceControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.balanceNameLabel = new System.Windows.Forms.Label();
            this.BalanceValueLabel = new System.Windows.Forms.Label();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Баланс";
            // 
            // balanceNameLabel
            // 
            this.balanceNameLabel.AutoSize = true;
            this.balanceNameLabel.BackColor = System.Drawing.Color.Green;
            this.balanceNameLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceNameLabel.ForeColor = System.Drawing.Color.White;
            this.balanceNameLabel.Location = new System.Drawing.Point(63, 210);
            this.balanceNameLabel.Name = "balanceNameLabel";
            this.balanceNameLabel.Size = new System.Drawing.Size(275, 55);
            this.balanceNameLabel.TabIndex = 1;
            this.balanceNameLabel.Text = "Ваш баланс:";
            // 
            // BalanceValueLabel
            // 
            this.BalanceValueLabel.AutoSize = true;
            this.BalanceValueLabel.BackColor = System.Drawing.Color.White;
            this.BalanceValueLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceValueLabel.ForeColor = System.Drawing.Color.Green;
            this.BalanceValueLabel.Location = new System.Drawing.Point(370, 220);
            this.BalanceValueLabel.Name = "BalanceValueLabel";
            this.BalanceValueLabel.Size = new System.Drawing.Size(86, 42);
            this.BalanceValueLabel.TabIndex = 2;
            this.BalanceValueLabel.Text = "label";
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackColor = System.Drawing.Color.Green;
            this.ReloadButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReloadButton.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.ReloadButton.ForeColor = System.Drawing.Color.White;
            this.ReloadButton.Location = new System.Drawing.Point(507, 309);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(251, 67);
            this.ReloadButton.TabIndex = 3;
            this.ReloadButton.Text = "Обновить";
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // BalanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.BalanceValueLabel);
            this.Controls.Add(this.balanceNameLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BalanceControl";
            this.Size = new System.Drawing.Size(801, 544);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceNameLabel;
        private System.Windows.Forms.Label BalanceValueLabel;
        private System.Windows.Forms.Button ReloadButton;
    }
}
