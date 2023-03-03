namespace Sberbank
{
    partial class AutorizationForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationForm));
            this.NumberCardLabel = new System.Windows.Forms.Label();
            this.PinCodeLabel = new System.Windows.Forms.Label();
            this.NumberCardTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PinCodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AutorizationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberCardLabel
            // 
            this.NumberCardLabel.AutoSize = true;
            this.NumberCardLabel.Location = new System.Drawing.Point(74, 103);
            this.NumberCardLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.NumberCardLabel.Name = "NumberCardLabel";
            this.NumberCardLabel.Size = new System.Drawing.Size(165, 31);
            this.NumberCardLabel.TabIndex = 0;
            this.NumberCardLabel.Text = "Номер карты";
            // 
            // PinCodeLabel
            // 
            this.PinCodeLabel.AutoSize = true;
            this.PinCodeLabel.Location = new System.Drawing.Point(74, 165);
            this.PinCodeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PinCodeLabel.Name = "PinCodeLabel";
            this.PinCodeLabel.Size = new System.Drawing.Size(109, 31);
            this.PinCodeLabel.TabIndex = 3;
            this.PinCodeLabel.Text = "Пин-код";
            // 
            // NumberCardTextBox
            // 
            this.NumberCardTextBox.ForeColor = System.Drawing.Color.Green;
            this.NumberCardTextBox.Location = new System.Drawing.Point(276, 96);
            this.NumberCardTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NumberCardTextBox.Mask = "0000-0000-0000-0000";
            this.NumberCardTextBox.Name = "NumberCardTextBox";
            this.NumberCardTextBox.Size = new System.Drawing.Size(275, 39);
            this.NumberCardTextBox.TabIndex = 4;
            // 
            // PinCodeTextBox
            // 
            this.PinCodeTextBox.ForeColor = System.Drawing.Color.Green;
            this.PinCodeTextBox.Location = new System.Drawing.Point(276, 158);
            this.PinCodeTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PinCodeTextBox.Mask = "0000";
            this.PinCodeTextBox.Name = "PinCodeTextBox";
            this.PinCodeTextBox.Size = new System.Drawing.Size(275, 39);
            this.PinCodeTextBox.TabIndex = 5;
            // 
            // AutorizationButton
            // 
            this.AutorizationButton.BackColor = System.Drawing.Color.Green;
            this.AutorizationButton.ForeColor = System.Drawing.Color.White;
            this.AutorizationButton.Location = new System.Drawing.Point(107, 227);
            this.AutorizationButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AutorizationButton.Name = "AutorizationButton";
            this.AutorizationButton.Size = new System.Drawing.Size(388, 72);
            this.AutorizationButton.TabIndex = 6;
            this.AutorizationButton.Text = "Войти";
            this.AutorizationButton.UseVisualStyleBackColor = false;
            this.AutorizationButton.Click += new System.EventHandler(this.AutorizationButton_Click);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(599, 421);
            this.Controls.Add(this.AutorizationButton);
            this.Controls.Add(this.PinCodeTextBox);
            this.Controls.Add(this.NumberCardTextBox);
            this.Controls.Add(this.PinCodeLabel);
            this.Controls.Add(this.NumberCardLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberCardLabel;
        private System.Windows.Forms.Label PinCodeLabel;
        private System.Windows.Forms.MaskedTextBox NumberCardTextBox;
        private System.Windows.Forms.MaskedTextBox PinCodeTextBox;
        private System.Windows.Forms.Button AutorizationButton;
    }
}

