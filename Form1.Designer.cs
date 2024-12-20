namespace Lab2_Wizhener
{
    partial class Form1
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
            this.textBox_EncryptText = new System.Windows.Forms.TextBox();
            this.textBox_DecryptText = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_EncryptText
            // 
            this.textBox_EncryptText.Location = new System.Drawing.Point(365, 50);
            this.textBox_EncryptText.Multiline = true;
            this.textBox_EncryptText.Name = "textBox_EncryptText";
            this.textBox_EncryptText.Size = new System.Drawing.Size(169, 214);
            this.textBox_EncryptText.TabIndex = 0;
            this.textBox_EncryptText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CryptTextBox);
            // 
            // textBox_DecryptText
            // 
            this.textBox_DecryptText.Location = new System.Drawing.Point(12, 50);
            this.textBox_DecryptText.Multiline = true;
            this.textBox_DecryptText.Name = "textBox_DecryptText";
            this.textBox_DecryptText.Size = new System.Drawing.Size(169, 214);
            this.textBox_DecryptText.TabIndex = 1;
            this.textBox_DecryptText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CryptTextBox);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(227, 206);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(100, 20);
            this.textBox_Key.TabIndex = 2;
            this.textBox_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CryptTextBox);
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.Location = new System.Drawing.Point(12, 280);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(169, 23);
            this.button_Encrypt.TabIndex = 3;
            this.button_Encrypt.Text = "Зашифровать";
            this.button_Encrypt.UseVisualStyleBackColor = true;
            this.button_Encrypt.Click += new System.EventHandler(this.Encode);
            // 
            // button_Decrypt
            // 
            this.button_Decrypt.Location = new System.Drawing.Point(365, 280);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(169, 23);
            this.button_Decrypt.TabIndex = 4;
            this.button_Decrypt.Text = "Расшифровать";
            this.button_Decrypt.UseVisualStyleBackColor = true;
            this.button_Decrypt.Click += new System.EventHandler(this.Decode);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Открытый текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Закрытый текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "КЛЮЧ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_DecryptText);
            this.Controls.Add(this.textBox_EncryptText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_EncryptText;
        private System.Windows.Forms.TextBox textBox_DecryptText;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.Button button_Decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

