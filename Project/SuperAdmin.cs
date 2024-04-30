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
    public partial class SuperAdmin : Form
    {
        public SuperAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void lklSRuyxatlari_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string pathSuperAdminFile = @"D:\C#PDP\Project\Project\SuperAdminFolder\SuperAdminFile.txt";

            string sw = File.ReadAllText(pathSuperAdminFile);
            MessageBox.Show(sw);
        }
    }
}
