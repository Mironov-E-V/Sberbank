namespace Sberbank.OpeningWindows
{
    partial class InputControl
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
            this.InputBalanceBox = new System.Windows.Forms.MaskedTextBox();
            this.InputBalanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пополнить";
            // 
            // InputBalanceBox
            // 
            this.InputBalanceBox.Font = new System.Drawing.Font("Times New Roman", 27.75F);
            this.InputBalanceBox.Location = new System.Drawing.Point(119, 227);
            this.InputBalanceBox.Mask = "000000";
            this.InputBalanceBox.Name = "InputBalanceBox";
            this.InputBalanceBox.Size = new System.Drawing.Size(215, 50);
            this.InputBalanceBox.TabIndex = 3;
            // 
            // InputBalanceButton
            // 
            this.InputBalanceButton.BackColor = System.Drawing.Color.Green;
            this.InputBalanceButton.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBalanceButton.ForeColor = System.Drawing.Color.White;
            this.InputBalanceButton.Location = new System.Drawing.Point(372, 219);
            this.InputBalanceButton.Name = "InputBalanceButton";
            this.InputBalanceButton.Size = new System.Drawing.Size(270, 64);
            this.InputBalanceButton.TabIndex = 4;
            this.InputBalanceButton.Text = "Пополнить";
            this.InputBalanceButton.UseVisualStyleBackColor = false;
            this.InputBalanceButton.Click += new System.EventHandler(this.InputBalanceButton_Click);
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.InputBalanceButton);
            this.Controls.Add(this.InputBalanceBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(801, 544);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox InputBalanceBox;
        private System.Windows.Forms.Button InputBalanceButton;
    }
}
