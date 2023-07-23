using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlHares_Data_Locker
{
	public partial class MainScreen : Form
	{
		public MainScreen()
		{
			InitializeComponent();
		}
		// Simple XOR encryption
		private string Encrypt(string plainText, string key)
		{
			try
			{
				byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);
				byte[] keyBytes = Encoding.Unicode.GetBytes(key);
				byte[] encryptedBytes = new byte[plainBytes.Length];

				for (int i = 0; i < plainBytes.Length; i++)
				{
					encryptedBytes[i] = (byte)(plainBytes[i] ^ keyBytes[i % keyBytes.Length]);
				}

				return Convert.ToBase64String(encryptedBytes);
			}
			catch (ArgumentNullException)
			{
				// Handle the case when either plainText or key is null.
				MessageBox.Show("Input is null. Please provide valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return string.Empty;
			}
			catch (Exception ex)
			{
				// Handle other exceptions that might occur during encryption.
				MessageBox.Show($"An error occurred during encryption: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return string.Empty;
			}
		}

		// Simple XOR decryption
		private string Decrypt(string encryptedText, string key)
		{
			try
			{
				byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
				byte[] keyBytes = Encoding.Unicode.GetBytes(key);
				byte[] decryptedBytes = new byte[encryptedBytes.Length];

				for (int i = 0; i < encryptedBytes.Length; i++)
				{
					decryptedBytes[i] = (byte)(encryptedBytes[i] ^ keyBytes[i % keyBytes.Length]);
				}

				return Encoding.Unicode.GetString(decryptedBytes);
			}
			catch (FormatException)
			{
				// The input string is not in a valid Base64 format.
				// Handle the error appropriately, e.g., show an error message.
				MessageBox.Show("Invalid input format. Please ensure the input is in a valid Base64 format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return string.Empty;
			}
			catch (ArgumentNullException)
			{
				// The input string is null.
				// Handle the error appropriately, e.g., show an error message.
				MessageBox.Show("Input is null. Please provide valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return string.Empty;
			}
			catch (Exception ex)
			{
				// Handle other exceptions that might occur during decryption.
				MessageBox.Show($"An error occurred during decryption: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return string.Empty;
			}
		}
		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			string key = txtKey.Text;
			string plainText = txtPlainText.Text;
			string encryptedText = Encrypt(plainText, key);
			txtConvertedText.Text = encryptedText;
		}

		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			string key = txtKey.Text;
			string encryptedText = txtPlainText.Text;
			string decryptedText = Decrypt(encryptedText, key);
			txtConvertedText.Text = decryptedText;
		}


		private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Close();
		}
	}
}
