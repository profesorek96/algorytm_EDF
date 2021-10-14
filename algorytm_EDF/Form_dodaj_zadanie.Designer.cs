
namespace algorytm_EDF
{
    partial class Form_dodaj_zadanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.dodaj = new System.Windows.Forms.Button();
            this.Zamknij = new System.Windows.Forms.Button();
            this.losuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deadline:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Czas wykonania";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(363, 25);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 31);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(363, 77);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(91, 31);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dodaj
            // 
            this.dodaj.BackColor = System.Drawing.Color.GreenYellow;
            this.dodaj.Location = new System.Drawing.Point(32, 155);
            this.dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(112, 36);
            this.dodaj.TabIndex = 4;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = false;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // Zamknij
            // 
            this.Zamknij.BackColor = System.Drawing.Color.Red;
            this.Zamknij.Location = new System.Drawing.Point(342, 157);
            this.Zamknij.Margin = new System.Windows.Forms.Padding(2);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(112, 36);
            this.Zamknij.TabIndex = 5;
            this.Zamknij.Text = "Anuluj";
            this.Zamknij.UseVisualStyleBackColor = false;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // losuj
            // 
            this.losuj.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.losuj.Location = new System.Drawing.Point(180, 157);
            this.losuj.Name = "losuj";
            this.losuj.Size = new System.Drawing.Size(112, 34);
            this.losuj.TabIndex = 6;
            this.losuj.Text = "Losuj";
            this.losuj.UseVisualStyleBackColor = false;
            this.losuj.Click += new System.EventHandler(this.losuj_Click);
            // 
            // Form_dodaj_zadanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 234);
            this.Controls.Add(this.losuj);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_dodaj_zadanie";
            this.Text = "Form dodaj zadanie";
            this.Load += new System.EventHandler(this.Form_dodaj_zadanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.Button losuj;
    }
}