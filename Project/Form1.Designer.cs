namespace Project
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
            btEnter = new Button();
            llbRegister = new LinkLabel();
            lbUserName = new Label();
            lbPassword = new Label();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            SuspendLayout();
            // 
            // btEnter
            // 
            btEnter.BackColor = SystemColors.Highlight;
            btEnter.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btEnter.Location = new Point(73, 233);
            btEnter.Name = "btEnter";
            btEnter.Size = new Size(361, 54);
            btEnter.TabIndex = 0;
            btEnter.Text = "Enter";
            btEnter.UseVisualStyleBackColor = false;
            btEnter.Click += btEnter_Click;
            // 
            // llbRegister
            // 
            llbRegister.AutoSize = true;
            llbRegister.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            llbRegister.Location = new Point(187, 312);
            llbRegister.Name = "llbRegister";
            llbRegister.Size = new Size(98, 31);
            llbRegister.TabIndex = 1;
            llbRegister.TabStop = true;
            llbRegister.Text = "Register";
            llbRegister.LinkClicked += llbRegister_LinkClicked;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lbUserName.Location = new Point(73, 91);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(123, 31);
            lbUserName.TabIndex = 2;
            lbUserName.Text = "UserName";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lbPassword.Location = new Point(73, 156);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(118, 31);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password ";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(209, 95);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(225, 27);
            tbUserName.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(209, 160);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(225, 27);
            tbPassword.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Controls.Add(llbRegister);
            Controls.Add(btEnter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEnter;
        private LinkLabel llbRegister;
        private Label lbUserName;
        private Label lbPassword;
        private TextBox tbUserName;
        private TextBox tbPassword;
    }
}
