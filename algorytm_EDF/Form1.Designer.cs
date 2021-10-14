
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
            this.zadania_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.czysc_liste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dodaj_zadanie
            // 
            this.dodaj_zadanie.Location = new System.Drawing.Point(32, 103);
            this.dodaj_zadanie.Margin = new System.Windows.Forms.Padding(2);
            this.dodaj_zadanie.Name = "dodaj_zadanie";
            this.dodaj_zadanie.Size = new System.Drawing.Size(180, 44);
            this.dodaj_zadanie.TabIndex = 0;
            this.dodaj_zadanie.Text = "Dodaj zadanie";
            this.dodaj_zadanie.UseVisualStyleBackColor = true;
            this.dodaj_zadanie.Click += new System.EventHandler(this.dodaj_zadanie_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(157, 44);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDown1.Size = new System.Drawing.Size(54, 31);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // generuj_zadanie
            // 
            this.generuj_zadanie.Location = new System.Drawing.Point(32, 177);
            this.generuj_zadanie.Margin = new System.Windows.Forms.Padding(2);
            this.generuj_zadanie.Name = "generuj_zadanie";
            this.generuj_zadanie.Size = new System.Drawing.Size(180, 36);
            this.generuj_zadanie.TabIndex = 2;
            this.generuj_zadanie.Text = "Generuj wykres";
            this.generuj_zadanie.UseVisualStyleBackColor = true;
            this.generuj_zadanie.Click += new System.EventHandler(this.generuj_zadanie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba maszyn";
            // 
            // zadania_list
            // 
            this.zadania_list.FormattingEnabled = true;
            this.zadania_list.ItemHeight = 25;
            this.zadania_list.Location = new System.Drawing.Point(328, 44);
            this.zadania_list.Name = "zadania_list";
            this.zadania_list.Size = new System.Drawing.Size(420, 179);
            this.zadania_list.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista zadań";
            // 
            // czysc_liste
            // 
            this.czysc_liste.Location = new System.Drawing.Point(32, 236);
            this.czysc_liste.Name = "czysc_liste";
            this.czysc_liste.Size = new System.Drawing.Size(179, 34);
            this.czysc_liste.TabIndex = 6;
            this.czysc_liste.Text = "Czyść listę";
            this.czysc_liste.UseVisualStyleBackColor = true;
            this.czysc_liste.Click += new System.EventHandler(this.czysc_liste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 305);
            this.Controls.Add(this.czysc_liste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zadania_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generuj_zadanie);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dodaj_zadanie);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ListBox zadania_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button czysc_liste;
    }
}

