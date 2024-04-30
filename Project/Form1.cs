using Microsoft.Win32;
using System.Text.Json;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            string pathUserlist = @"D:\C#PDP\Project\Project\UsersList.txt";
            string[] readOnlyUserList = File.ReadAllLines(pathUserlist);
            /*
            if(tbUserName.Text == "istamovMM" && tbPassword.Text == "081204")
            {
                this.Hide();
                SuperAdmin superAdmin = new SuperAdmin();
                superAdmin.Show();
            }
            else if((tbUserName.Text =="hayot3003" && tbPassword.Text == "300304") || (tbUserName.Text == "oybek0626" && tbPassword.Text =="060604"))
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            else if(readOnlyUserList.Contains(tbUserName.Text))
            {
                this.Hide();
                Client client = new Client();
                client.Show();
            }
            else
            {
                tbUserName.Clear();
                tbPassword.Clear();
                MessageBox.Show("Siz Ro'yxatdan o'tmagansiz. Avval Ro'yxatdan o'ting");
            }
            */

            List<Users> users = new List<Users>();

            for (int i = 0; i < readOnlyUserList.Length; i++)
            {
                string[] userListLine = readOnlyUserList[i].Split(",");
                users.Add(new Users() { Id = int.Parse(userListLine[0]),UserType = userListLine[1],FIO = userListLine[2],UserName = userListLine[3], Password = userListLine[4]});
            }
            int sanoq = 0;
            foreach(Users user in users)
            {
                if(user.UserName == tbUserName.Text && user.Password == tbPassword.Text) 
                {
                    sanoq++;
                    if(user.UserType == "SuperAdmin")
                    {
                        string pathSuperAdminFolder = @"D:\C#PDP\Project\Project\SuperAdminFolder";
                        string pathSuperAdminFile = @"D:\C#PDP\Project\Project\SuperAdminFolder\SuperAdminFile.txt";

                        Directory.CreateDirectory(pathSuperAdminFolder);
                        StreamWriter sw =  File.CreateText(pathSuperAdminFile);

                       

                        int index = 1;
                        foreach(Users users1 in users)
                        {
                            if(users1.UserType == "SuperAdmin")
                            {
                                continue;
                            }

                            sw.WriteLine(index++.ToString()+ "," + users1.UserType + "," + users1.FIO + "," +users1.UserName+ "," + users1.Password);
                        }
                        sw.Close();
                        this.Hide();
                        SuperAdmin superAdmin = new SuperAdmin();
                        superAdmin.Show();
                    }
                    else if(user.UserType == "Admin")
                    {
                        string pathAdminFolder = @"D:\C#PDP\Project\Project\AdminFolder";
                        string pathAdminFile = @"D:\C#PDP\Project\Project\AdminFolder\AdminFile.txt";

                        Directory.CreateDirectory(pathAdminFolder);
                        StreamWriter sw = File.CreateText(pathAdminFile);



                        int index = 1;
                        foreach (Users users1 in users)
                        {
                            if (users1.UserType == "Client")
                            {
                                sw.WriteLine(index++.ToString() + "," + users1.UserType + "," + users1.FIO + "," + users1.UserName + "," + users1.Password);
                            }
                        }
                        sw.Close();
                        this.Hide();
                        Admin admin = new Admin();
                        admin.Show();
                    }
                    else
                    {
                        Users users1 = new Users();

                        foreach(Users users2 in users)
                        {
                            if(tbUserName.Text == users2.UserName)
                            {
                                users1.FIO = users2.FIO;
                                users1.UserName = users2.UserName;
                                users1.Password = users2.Password;
                                users1.UserType = users2.UserType;
                            }
                        }
                        string jsonString = JsonSerializer.Serialize(users1);
                        string pathClientFolder = @"D:\C#PDP\Project\Project\ClientFolder";
                        string pathClientFile = @"ClientFile.txt";

                        string combineFile = Path.Combine(pathClientFolder,pathClientFile);


                        Directory.CreateDirectory(pathClientFolder);
                        StreamWriter streamWriter = File.CreateText(combineFile);
                        streamWriter.WriteLine(jsonString);
                        streamWriter.Close();

                        this.Hide();
                        Client client = new Client();
                        client.Show();
                    }
                }
            }        
            if(sanoq == 0)
            {
                tbPassword.Clear();
                tbUserName.Clear();
                MessageBox.Show("Login yoki Parol xato");
            }
        }
        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide(); 
            RegisterForm register = new RegisterForm();
            register.StartPosition = FormStartPosition.CenterScreen;
            register.Show();
        }
    }
}
