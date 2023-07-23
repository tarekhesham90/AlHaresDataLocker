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
			byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);
			byte[] keyBytes = Encoding.Unicode.GetBytes(key);
			byte[] encryptedBytes = new byte[plainBytes.Length];

			for (int i = 0; i < plainBytes.Length; i++)
			{
				encryptedBytes[i] = (byte)(plainBytes[i] ^ keyBytes[i % keyBytes.Length]);
			}

			return Convert.ToBase64String(encryptedBytes);
		}

		// Simple XOR decryption
		private string Decrypt(string encryptedText, string key)
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
			string encryptedText = txtConvertedText.Text;
			string decryptedText = Decrypt(encryptedText, key);
			txtConvertedText.Text = decryptedText;
		}
	}
}
