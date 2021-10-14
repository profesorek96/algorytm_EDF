
namespace algorytm_EDF
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
            this.dodaj_zadanie = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.generuj_zadanie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dodaj_zadanie
            // 
            this.dodaj_zadanie.Location = new System.Drawing.Point(63, 198);
            this.dodaj_zadanie.Name = "dodaj_zadanie";
            this.dodaj_zadanie.Size = new System.Drawing.Size(359, 85);
            this.dodaj_zadanie.TabIndex = 0;
            this.dodaj_zadanie.Text = "Dodaj zadanie";
            this.dodaj_zadanie.UseVisualStyleBackColor = true;
            this.dodaj_zadanie.Click += new System.EventHandler(this.dodaj_zadanie_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(314, 84);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(108, 55);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // generuj_zadanie
            // 
            this.generuj_zadanie.Location = new System.Drawing.Point(63, 340);
            this.generuj_zadanie.Name = "generuj_zadanie";
            this.generuj_zadanie.Size = new System.Drawing.Size(359, 69);
            this.generuj_zadanie.TabIndex = 2;
            this.generuj_zadanie.Text = "Generuj wykres";
            this.generuj_zadanie.UseVisualStyleBackColor = true;
            this.generuj_zadanie.Click += new System.EventHandler(this.generuj_zadanie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba maszyn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generuj_zadanie);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dodaj_zadanie);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "EDF";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj_zadanie;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button generuj_zadanie;
        private System.Windows.Forms.Label label1;
    }
}

