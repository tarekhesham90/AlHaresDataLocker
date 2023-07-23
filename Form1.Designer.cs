namespace AlHares_Data_Locker
{
	partial class MainScreen
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
			this.KeyLabel = new System.Windows.Forms.Label();
			this.txtKey = new System.Windows.Forms.TextBox();
			this.txtPlainText = new System.Windows.Forms.TextBox();
			this.txtConvertedText = new System.Windows.Forms.TextBox();
			this.PlainTextLabel = new System.Windows.Forms.Label();
			this.ConvertedTextLabel = new System.Windows.Forms.Label();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// KeyLabel
			// 
			this.KeyLabel.AutoSize = true;
			this.KeyLabel.Location = new System.Drawing.Point(47, 19);
			this.KeyLabel.Name = "KeyLabel";
			this.KeyLabel.Size = new System.Drawing.Size(25, 13);
			this.KeyLabel.TabIndex = 0;
			this.KeyLabel.Text = "Key";
			// 
			// txtKey
			// 
			this.txtKey.Location = new System.Drawing.Point(50, 35);
			this.txtKey.Name = "txtKey";
			this.txtKey.Size = new System.Drawing.Size(171, 20);
			this.txtKey.TabIndex = 1;
			// 
			// txtPlainText
			// 
			this.txtPlainText.Location = new System.Drawing.Point(50, 93);
			this.txtPlainText.Multiline = true;
			this.txtPlainText.Name = "txtPlainText";
			this.txtPlainText.Size = new System.Drawing.Size(681, 141);
			this.txtPlainText.TabIndex = 2;
			// 
			// txtConvertedText
			// 
			this.txtConvertedText.Location = new System.Drawing.Point(50, 354);
			this.txtConvertedText.Multiline = true;
			this.txtConvertedText.Name = "txtConvertedText";
			this.txtConvertedText.Size = new System.Drawing.Size(681, 155);
			this.txtConvertedText.TabIndex = 3;
			// 
			// PlainTextLabel
			// 
			this.PlainTextLabel.AutoSize = true;
			this.PlainTextLabel.Location = new System.Drawing.Point(47, 77);
			this.PlainTextLabel.Name = "PlainTextLabel";
			this.PlainTextLabel.Size = new System.Drawing.Size(54, 13);
			this.PlainTextLabel.TabIndex = 4;
			this.PlainTextLabel.Text = "Plain Text";
			// 
			// ConvertedTextLabel
			// 
			this.ConvertedTextLabel.AutoSize = true;
			this.ConvertedTextLabel.Location = new System.Drawing.Point(47, 338);
			this.ConvertedTextLabel.Name = "ConvertedTextLabel";
			this.ConvertedTextLabel.Size = new System.Drawing.Size(80, 13);
			this.ConvertedTextLabel.TabIndex = 5;
			this.ConvertedTextLabel.Text = "Converted Text";
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Location = new System.Drawing.Point(173, 256);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(169, 63);
			this.btnEncrypt.TabIndex = 6;
			this.btnEncrypt.Text = "Encryption";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(428, 256);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(169, 63);
			this.btnDecrypt.TabIndex = 7;
			this.btnDecrypt.Text = "Decryption";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.btnEncrypt);
			this.Controls.Add(this.ConvertedTextLabel);
			this.Controls.Add(this.PlainTextLabel);
			this.Controls.Add(this.txtConvertedText);
			this.Controls.Add(this.txtPlainText);
			this.Controls.Add(this.txtKey);
			this.Controls.Add(this.KeyLabel);
			this.Name = "MainScreen";
			this.Text = "AlHares Data Locker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label KeyLabel;
		private System.Windows.Forms.TextBox txtKey;
		private System.Windows.Forms.TextBox txtPlainText;
		private System.Windows.Forms.TextBox txtConvertedText;
		private System.Windows.Forms.Label PlainTextLabel;
		private System.Windows.Forms.Label ConvertedTextLabel;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.Button btnDecrypt;
	}
}

