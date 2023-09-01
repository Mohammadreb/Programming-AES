
namespace AES_Program
{
    partial class AES
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plaintxt = new System.Windows.Forms.TextBox();
            this.ciphertxt = new System.Windows.Forms.TextBox();
            this.keytxt = new System.Windows.Forms.TextBox();
            this.originaltxt = new System.Windows.Forms.TextBox();
            this.encryptbtn = new System.Windows.Forms.Button();
            this.decryptbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PlainText";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "CipherText";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "OriginalText";
            // 
            // plaintxt
            // 
            this.plaintxt.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plaintxt.Location = new System.Drawing.Point(34, 100);
            this.plaintxt.Multiline = true;
            this.plaintxt.Name = "plaintxt";
            this.plaintxt.Size = new System.Drawing.Size(530, 57);
            this.plaintxt.TabIndex = 4;
            // 
            // ciphertxt
            // 
            this.ciphertxt.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ciphertxt.Location = new System.Drawing.Point(34, 295);
            this.ciphertxt.Multiline = true;
            this.ciphertxt.Name = "ciphertxt";
            this.ciphertxt.ReadOnly = true;
            this.ciphertxt.Size = new System.Drawing.Size(530, 83);
            this.ciphertxt.TabIndex = 5;
            // 
            // keytxt
            // 
            this.keytxt.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keytxt.Location = new System.Drawing.Point(34, 189);
            this.keytxt.Multiline = true;
            this.keytxt.Name = "keytxt";
            this.keytxt.Size = new System.Drawing.Size(530, 59);
            this.keytxt.TabIndex = 6;
            // 
            // originaltxt
            // 
            this.originaltxt.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.originaltxt.Location = new System.Drawing.Point(34, 423);
            this.originaltxt.Multiline = true;
            this.originaltxt.Name = "originaltxt";
            this.originaltxt.ReadOnly = true;
            this.originaltxt.Size = new System.Drawing.Size(530, 59);
            this.originaltxt.TabIndex = 7;
            // 
            // encryptbtn
            // 
            this.encryptbtn.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encryptbtn.Location = new System.Drawing.Point(590, 251);
            this.encryptbtn.Name = "encryptbtn";
            this.encryptbtn.Size = new System.Drawing.Size(159, 53);
            this.encryptbtn.TabIndex = 8;
            this.encryptbtn.Text = "Encrypt";
            this.encryptbtn.UseVisualStyleBackColor = true;
            this.encryptbtn.Click += new System.EventHandler(this.encryptbtn_Click);
            // 
            // decryptbtn
            // 
            this.decryptbtn.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decryptbtn.Location = new System.Drawing.Point(590, 390);
            this.decryptbtn.Name = "decryptbtn";
            this.decryptbtn.Size = new System.Drawing.Size(159, 56);
            this.decryptbtn.TabIndex = 9;
            this.decryptbtn.Text = "Decrypt";
            this.decryptbtn.UseVisualStyleBackColor = true;
            this.decryptbtn.Click += new System.EventHandler(this.decryptbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(101, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(639, 47);
            this.label5.TabIndex = 10;
            this.label5.Text = "The Advanced Encryption Standard (AES)";
            // 
            // AES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 494);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decryptbtn);
            this.Controls.Add(this.encryptbtn);
            this.Controls.Add(this.originaltxt);
            this.Controls.Add(this.keytxt);
            this.Controls.Add(this.ciphertxt);
            this.Controls.Add(this.plaintxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AES";
            this.Text = "AES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox plaintxt;
        private System.Windows.Forms.TextBox ciphertxt;
        private System.Windows.Forms.TextBox keytxt;
        private System.Windows.Forms.TextBox originaltxt;
        private System.Windows.Forms.Button encryptbtn;
        private System.Windows.Forms.Button decryptbtn;
        private System.Windows.Forms.Label label5;
    }
}

