
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
            this.generuj_zadanie = new System.Windows.Forms.Button();
            this.zadania_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.czysc_liste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodaj_zadanie
            // 
            this.dodaj_zadanie.Location = new System.Drawing.Point(31, 44);
            this.dodaj_zadanie.Margin = new System.Windows.Forms.Padding(2);
            this.dodaj_zadanie.Name = "dodaj_zadanie";
            this.dodaj_zadanie.Size = new System.Drawing.Size(180, 44);
            this.dodaj_zadanie.TabIndex = 0;
            this.dodaj_zadanie.Text = "Dodaj zadanie";
            this.dodaj_zadanie.UseVisualStyleBackColor = true;
            this.dodaj_zadanie.Click += new System.EventHandler(this.dodaj_zadanie_Click);
            // 
            // generuj_zadanie
            // 
            this.generuj_zadanie.Location = new System.Drawing.Point(31, 119);
            this.generuj_zadanie.Margin = new System.Windows.Forms.Padding(2);
            this.generuj_zadanie.Name = "generuj_zadanie";
            this.generuj_zadanie.Size = new System.Drawing.Size(180, 36);
            this.generuj_zadanie.TabIndex = 2;
            this.generuj_zadanie.Text = "Generuj wykres";
            this.generuj_zadanie.UseVisualStyleBackColor = true;
            this.generuj_zadanie.Click += new System.EventHandler(this.generuj_zadanie_Click);
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
            this.czysc_liste.Location = new System.Drawing.Point(32, 189);
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
            this.Controls.Add(this.generuj_zadanie);
            this.Controls.Add(this.dodaj_zadanie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "EDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj_zadanie;
        private System.Windows.Forms.Button generuj_zadanie;
        private System.Windows.Forms.ListBox zadania_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button czysc_liste;
    }
}

