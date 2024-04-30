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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  
            string pathAdminFile = @"D:\C#PDP\Project\Project\AdminFolder\AdminFile.txt";
            string sw = File.ReadAllText(pathAdminFile);
            MessageBox.Show(sw);
        }
    }
}
