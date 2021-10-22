using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace myRSA
{
    public partial class Form1 : Form
    {
        String publicKey, privateKey;
        UnicodeEncoding encoder = new UnicodeEncoding();
        public Form1()
        {
            RSACryptoServiceProvider myRSA = new RSACryptoServiceProvider();
            InitializeComponent();
            privateKey = myRSA.ToXmlString(true);
            publicKey = myRSA.ToXmlString(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtPlainText.Text = "";
            txtPlainText.Refresh();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var myRSA = new RSACryptoServiceProvider();
            myRSA.FromXmlString(publicKey);
            var dataToEncrypt = encoder.GetBytes(txtPlainText.Text);
            var encryptedByteArray = myRSA.Encrypt(dataToEncrypt, false).ToArray();

            var length = encryptedByteArray.Count();
            var item = 0;
            var sb = new StringBuilder();

            foreach(var x in encryptedByteArray)
            {
                item++;
                sb.Append(x);
                if (item < length) sb.Append(",");
            }
            txtCypherText.Text = sb.ToString();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var myRSA = new RSACryptoServiceProvider();
            var dataArray = txtCypherText.Text.Split(new char[] { ',' });

            byte[] dataByte = new byte[dataArray.Length];
            for (int i = 0; i < dataArray.Length; i++) dataByte[i] = Convert.ToByte(dataArray[i]);

            myRSA.FromXmlString(privateKey);
            var decryptedBytes = myRSA.Decrypt(dataByte, false);

            txtPlainText.Text = encoder.GetString(decryptedBytes);
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtCypherText.Text = "";
            txtCypherText.Refresh();
        }
    }
}
