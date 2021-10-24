
namespace algorytm_EDF
{
    partial class Wykres
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dodaj_task = new System.Windows.Forms.Button();
            this.stop_sim = new System.Windows.Forms.Button();
            this.start_sim = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 374);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dodaj_task);
            this.panel2.Controls.Add(this.stop_sim);
            this.panel2.Controls.Add(this.start_sim);
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 71);
            this.panel2.TabIndex = 1;
            // 
            // dodaj_task
            // 
            this.dodaj_task.BackColor = System.Drawing.SystemColors.Highlight;
            this.dodaj_task.Location = new System.Drawing.Point(580, 24);
            this.dodaj_task.Name = "dodaj_task";
            this.dodaj_task.Size = new System.Drawing.Size(208, 34);
            this.dodaj_task.TabIndex = 2;
            this.dodaj_task.Text = "Dodaj zadanie";
            this.dodaj_task.UseVisualStyleBackColor = false;
            this.dodaj_task.Click += new System.EventHandler(this.dodaj_task_Click);
            // 
            // stop_sim
            // 
            this.stop_sim.BackColor = System.Drawing.Color.Red;
            this.stop_sim.Location = new System.Drawing.Point(208, 24);
            this.stop_sim.Name = "stop_sim";
            this.stop_sim.Size = new System.Drawing.Size(112, 34);
            this.stop_sim.TabIndex = 1;
            this.stop_sim.Text = "Stop";
            this.stop_sim.UseVisualStyleBackColor = false;
            this.stop_sim.Click += new System.EventHandler(this.stop_sim_Click);
            // 
            // start_sim
            // 
            this.start_sim.BackColor = System.Drawing.Color.Lime;
            this.start_sim.Location = new System.Drawing.Point(61, 24);
            this.start_sim.Name = "start_sim";
            this.start_sim.Size = new System.Drawing.Size(112, 34);
            this.start_sim.TabIndex = 0;
            this.start_sim.Text = "Start";
            this.start_sim.UseVisualStyleBackColor = false;
            this.start_sim.Click += new System.EventHandler(this.start_sim_Click);
            // 
            // Wykres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Wykres";
            this.Text = "Wykres";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button start_sim;
        private System.Windows.Forms.Button dodaj_task;
        private System.Windows.Forms.Button stop_sim;
    }
}