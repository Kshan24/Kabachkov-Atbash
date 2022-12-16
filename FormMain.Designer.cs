
namespace Шифр_Атбаш
{
    partial class FormMain
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
            this.buttonzashifr = new System.Windows.Forms.Button();
            this.buttondeshifr = new System.Windows.Forms.Button();
            this.SearchID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxNachalo = new System.Windows.Forms.TextBox();
            this.textBoxvevod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonzashifr
            // 
            this.buttonzashifr.Location = new System.Drawing.Point(205, 45);
            this.buttonzashifr.Name = "buttonzashifr";
            this.buttonzashifr.Size = new System.Drawing.Size(118, 46);
            this.buttonzashifr.TabIndex = 0;
            this.buttonzashifr.Text = "зашифровать";
            this.buttonzashifr.UseVisualStyleBackColor = true;
            this.buttonzashifr.Click += new System.EventHandler(this.Buttonzashifr_Click);
            // 
            // buttondeshifr
            // 
            this.buttondeshifr.Location = new System.Drawing.Point(205, 97);
            this.buttondeshifr.Name = "buttondeshifr";
            this.buttondeshifr.Size = new System.Drawing.Size(118, 46);
            this.buttondeshifr.TabIndex = 1;
            this.buttondeshifr.Text = "дешифровать";
            this.buttondeshifr.UseVisualStyleBackColor = true;
            this.buttondeshifr.Click += new System.EventHandler(this.Buttondeshifr_Click);
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(207, 260);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(116, 23);
            this.SearchID.TabIndex = 3;
            this.SearchID.Text = "Найти текст";
            this.SearchID.UseVisualStyleBackColor = true;
            this.SearchID.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 222);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNachalo
            // 
            this.textBoxNachalo.Location = new System.Drawing.Point(5, 47);
            this.textBoxNachalo.Multiline = true;
            this.textBoxNachalo.Name = "textBoxNachalo";
            this.textBoxNachalo.Size = new System.Drawing.Size(171, 236);
            this.textBoxNachalo.TabIndex = 6;
            this.textBoxNachalo.TextChanged += new System.EventHandler(this.Nachalo_TextChanged);
            // 
            // textBoxvevod
            // 
            this.textBoxvevod.Location = new System.Drawing.Point(346, 47);
            this.textBoxvevod.Multiline = true;
            this.textBoxvevod.Name = "textBoxvevod";
            this.textBoxvevod.Size = new System.Drawing.Size(176, 236);
            this.textBoxvevod.TabIndex = 7;
            this.textBoxvevod.TextChanged += new System.EventHandler(this.vevod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "зашифрованный текст";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "дешифрованный текст";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxvevod);
            this.Controls.Add(this.textBoxNachalo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchID);
            this.Controls.Add(this.buttondeshifr);
            this.Controls.Add(this.buttonzashifr);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonzashifr;
        private System.Windows.Forms.Button buttondeshifr;
        private System.Windows.Forms.Button SearchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxNachalo;
        private System.Windows.Forms.TextBox textBoxvevod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}