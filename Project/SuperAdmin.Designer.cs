namespace Project
{
    partial class SuperAdmin
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
            label1 = new Label();
            label2 = new Label();
            lklSRuyxatlari = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.Location = new Point(136, 61);
            label1.Name = "label1";
            label1.Size = new Size(217, 46);
            label1.TabIndex = 0;
            label1.Text = "File yaratildi";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(206, 38);
            label2.TabIndex = 1;
            label2.Text = "Ro'yxat linki=>";
            // 
            // lklSRuyxatlari
            // 
            lklSRuyxatlari.AutoSize = true;
            lklSRuyxatlari.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lklSRuyxatlari.Location = new Point(233, 164);
            lklSRuyxatlari.Name = "lklSRuyxatlari";
            lklSRuyxatlari.Size = new Size(200, 38);
            lklSRuyxatlari.TabIndex = 2;
            lklSRuyxatlari.TabStop = true;
            lklSRuyxatlari.Text = "Ro'yxatlar linki";
            lklSRuyxatlari.LinkClicked += lklSRuyxatlari_LinkClicked;
            // 
            // SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 469);
            Controls.Add(lklSRuyxatlari);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SuperAdmin";
            Text = "SuperAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel lklSRuyxatlari;
    }
}