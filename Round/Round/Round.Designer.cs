
namespace Round
{
    partial class Round
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
            this.plaintxt = new System.Windows.Forms.TextBox();
            this.ciphertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plaintxt
            // 
            this.plaintxt.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plaintxt.Location = new System.Drawing.Point(12, 67);
            this.plaintxt.Name = "plaintxt";
            this.plaintxt.Size = new System.Drawing.Size(423, 34);
            this.plaintxt.TabIndex = 0;
            // 
            // ciphertxt
            // 
            this.ciphertxt.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ciphertxt.Location = new System.Drawing.Point(17, 231);
            this.ciphertxt.Name = "ciphertxt";
            this.ciphertxt.ReadOnly = true;
            this.ciphertxt.Size = new System.Drawing.Size(418, 34);
            this.ciphertxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "PlainText";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "CipherText";
            // 
            // encryptbtn
            // 
            this.encryptbtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encryptbtn.Location = new System.Drawing.Point(12, 130);
            this.encryptbtn.Name = "encryptbtn";
            this.encryptbtn.Size = new System.Drawing.Size(151, 45);
            this.encryptbtn.TabIndex = 4;
            this.encryptbtn.Text = "Encrypt";
            this.encryptbtn.UseVisualStyleBackColor = true;
            this.encryptbtn.Click += new System.EventHandler(this.encryptbtn_Click);
            // 
            // Round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 290);
            this.Controls.Add(this.encryptbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ciphertxt);
            this.Controls.Add(this.plaintxt);
            this.Name = "Round";
            this.Text = "Round";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plaintxt;
        private System.Windows.Forms.TextBox ciphertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encryptbtn;
    }
}

