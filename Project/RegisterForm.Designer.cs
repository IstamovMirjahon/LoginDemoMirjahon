namespace Project
{
    partial class RegisterForm
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
            btRegister = new Button();
            tbFIO = new TextBox();
            lbUserName = new Label();
            tbPasswordR = new TextBox();
            lbPassword = new Label();
            tbUserNameR = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btRegister
            // 
            btRegister.BackColor = SystemColors.HotTrack;
            btRegister.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btRegister.ForeColor = SystemColors.ActiveCaptionText;
            btRegister.Location = new Point(71, 277);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(366, 66);
            btRegister.TabIndex = 0;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = false;
            btRegister.Click += btRegister_Click;
            // 
            // tbFIO
            // 
            tbFIO.Location = new Point(203, 101);
            tbFIO.Name = "tbFIO";
            tbFIO.Size = new Size(225, 27);
            tbFIO.TabIndex = 6;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lbUserName.Location = new Point(67, 101);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(50, 31);
            lbUserName.TabIndex = 5;
            lbUserName.Text = "FIO";
            // 
            // tbPasswordR
            // 
            tbPasswordR.Location = new Point(203, 209);
            tbPasswordR.Name = "tbPasswordR";
            tbPasswordR.PasswordChar = '*';
            tbPasswordR.Size = new Size(225, 27);
            tbPasswordR.TabIndex = 8;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lbPassword.Location = new Point(67, 205);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(118, 31);
            lbPassword.TabIndex = 7;
            lbPassword.Text = "Password ";
            // 
            // tbUserNameR
            // 
            tbUserNameR.Location = new Point(203, 163);
            tbUserNameR.Name = "tbUserNameR";
            tbUserNameR.Size = new Size(225, 27);
            tbUserNameR.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(67, 159);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 9;
            label1.Text = "UserName";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(tbUserNameR);
            Controls.Add(label1);
            Controls.Add(tbPasswordR);
            Controls.Add(lbPassword);
            Controls.Add(tbFIO);
            Controls.Add(lbUserName);
            Controls.Add(btRegister);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRegister;
        private TextBox tbFIO;
        private Label lbUserName;
        private TextBox tbPasswordR;
        private Label lbPassword;
        private TextBox tbUserNameR;
        private Label label1;
    }
}