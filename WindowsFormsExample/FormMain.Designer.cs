
namespace WindowsFormsExample
{
    partial class FormMain
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
            this.textBoxvevod = new System.Windows.Forms.TextBox();
            this.textBoxnachalo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonzashifr = new System.Windows.Forms.Button();
            this.buttondeshifr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxvevod
            // 
            this.textBoxvevod.Location = new System.Drawing.Point(486, 93);
            this.textBoxvevod.Multiline = true;
            this.textBoxvevod.Name = "textBoxvevod";
            this.textBoxvevod.Size = new System.Drawing.Size(176, 236);
            this.textBoxvevod.TabIndex = 11;
            this.textBoxvevod.TextChanged += new System.EventHandler(this.textBoxvevod_TextChanged);
            // 
            // textBoxnachalo
            // 
            this.textBoxnachalo.Location = new System.Drawing.Point(92, 93);
            this.textBoxnachalo.Multiline = true;
            this.textBoxnachalo.Name = "textBoxnachalo";
            this.textBoxnachalo.Size = new System.Drawing.Size(171, 236);
            this.textBoxnachalo.TabIndex = 12;
            this.textBoxnachalo.TextChanged += new System.EventHandler(this.textBoxnachalo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "зашифрованный текст";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "дешифрованный текст";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonzashifr
            // 
            this.buttonzashifr.Location = new System.Drawing.Point(316, 93);
            this.buttonzashifr.Name = "buttonzashifr";
            this.buttonzashifr.Size = new System.Drawing.Size(118, 46);
            this.buttonzashifr.TabIndex = 15;
            this.buttonzashifr.Text = "зашифровать";
            this.buttonzashifr.UseVisualStyleBackColor = true;
            this.buttonzashifr.Click += new System.EventHandler(this.Buttonzashifr_Click);
            // 
            // buttondeshifr
            // 
            this.buttondeshifr.Location = new System.Drawing.Point(316, 158);
            this.buttondeshifr.Name = "buttondeshifr";
            this.buttondeshifr.Size = new System.Drawing.Size(118, 46);
            this.buttondeshifr.TabIndex = 16;
            this.buttondeshifr.Text = "дешифровать";
            this.buttondeshifr.UseVisualStyleBackColor = true;
            this.buttondeshifr.Click += new System.EventHandler(this.Buttondeshifr_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttondeshifr);
            this.Controls.Add(this.buttonzashifr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxnachalo);
            this.Controls.Add(this.textBoxvevod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Курсовая работа";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxvevod;
        private System.Windows.Forms.TextBox textBoxnachalo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonzashifr;
        private System.Windows.Forms.Button buttondeshifr;
    }
}

