
namespace Key_Expansion
{
    partial class Form1
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
            this.keytxt = new System.Windows.Forms.TextBox();
            this.keyextxt = new System.Windows.Forms.TextBox();
            this.keybtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keytxt
            // 
            this.keytxt.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keytxt.Location = new System.Drawing.Point(69, 71);
            this.keytxt.Multiline = true;
            this.keytxt.Name = "keytxt";
            this.keytxt.Size = new System.Drawing.Size(405, 48);
            this.keytxt.TabIndex = 0;
            // 
            // keyextxt
            // 
            this.keyextxt.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keyextxt.Location = new System.Drawing.Point(69, 194);
            this.keyextxt.Multiline = true;
            this.keyextxt.Name = "keyextxt";
            this.keyextxt.ReadOnly = true;
            this.keyextxt.Size = new System.Drawing.Size(405, 45);
            this.keyextxt.TabIndex = 1;
            // 
            // keybtn
            // 
            this.keybtn.BackColor = System.Drawing.Color.Gray;
            this.keybtn.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keybtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keybtn.Location = new System.Drawing.Point(115, 283);
            this.keybtn.Name = "keybtn";
            this.keybtn.Size = new System.Drawing.Size(202, 60);
            this.keybtn.TabIndex = 2;
            this.keybtn.Text = "Expansion";
            this.keybtn.UseVisualStyleBackColor = false;
            this.keybtn.Click += new System.EventHandler(this.keybtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(69, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(69, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key Expansion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keybtn);
            this.Controls.Add(this.keyextxt);
            this.Controls.Add(this.keytxt);
            this.Name = "Form1";
            this.Text = "Key Expansion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keytxt;
        private System.Windows.Forms.TextBox keyextxt;
        private System.Windows.Forms.Button keybtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

