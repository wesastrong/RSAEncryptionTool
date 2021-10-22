
namespace myRSA
{
    partial class Form1
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.txtCypherText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(193, 124);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(115, 39);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(408, 124);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(115, 39);
            this.btnClear1.TabIndex = 1;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(932, 124);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(115, 39);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(1146, 124);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(115, 39);
            this.btnClear2.TabIndex = 3;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(103, 212);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(528, 503);
            this.txtPlainText.TabIndex = 4;
            this.txtPlainText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCypherText
            // 
            this.txtCypherText.Location = new System.Drawing.Point(831, 212);
            this.txtCypherText.Multiline = true;
            this.txtCypherText.Name = "txtCypherText";
            this.txtCypherText.Size = new System.Drawing.Size(528, 503);
            this.txtCypherText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 924);
            this.Controls.Add(this.txtCypherText);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form1";
            this.Text = "Encryption Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.TextBox txtCypherText;
    }
}

