using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            string path = @"D:\C#PDP\Project\Project\UsersList.txt";
            string[] userlistLength = File.ReadAllLines(path);
            //string ReadUserList = File.ReadAllText(path);
            
            if(tbFIO.Text.Length > 0 && tbPasswordR.Text.Length > 0 &&tbUserNameR.Text.Length > 0)
            {
                if (!path.Contains(tbUserNameR.Text))
                {
                    File.AppendAllText(path, "\n"+ userlistLength.Length+1 + "," + UserType.Client + "," + tbFIO.Text + "," + tbUserNameR.Text + "," + tbPasswordR.Text);
                    MessageBox.Show("Muvaffaqiyatli ro'yxatdan o'tdingiz!");
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.StartPosition = FormStartPosition.CenterScreen;
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Bu Username bor. Boshqa username yarating");
                    tbUserNameR.Clear();
                }
            }
            else
            {
                MessageBox.Show("Bo'sh qiymat yubordingiz.Iltimos qayta kiriting");
            }    
        }
        public enum UserType
        {
            SuperAdmin = 1,
            Admin,
            Client
        }
    }
}
