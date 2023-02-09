namespace Merge_Sort
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_vystup = new System.Windows.Forms.TextBox();
            this.nmr_random = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_random)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_vystup
            // 
            this.txt_vystup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_vystup.Location = new System.Drawing.Point(12, 12);
            this.txt_vystup.Multiline = true;
            this.txt_vystup.Name = "txt_vystup";
            this.txt_vystup.Size = new System.Drawing.Size(895, 319);
            this.txt_vystup.TabIndex = 0;
            // 
            // nmr_random
            // 
            this.nmr_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmr_random.Location = new System.Drawing.Point(1068, 73);
            this.nmr_random.Name = "nmr_random";
            this.nmr_random.Size = new System.Drawing.Size(117, 30);
            this.nmr_random.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(913, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 157);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_generuj_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(913, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 157);
            this.button2.TabIndex = 2;
            this.button2.Text = "Merge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Merge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nmr_random);
            this.Controls.Add(this.txt_vystup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_random)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_vystup;
        private System.Windows.Forms.NumericUpDown nmr_random;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

