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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string pathClient = @"D:\C#PDP\Project\Project\ClientFolder\ClientFile.txt";
            string clientFile = File.ReadAllText(pathClient);

            MessageBox.Show(clientFile);
        }
    }
}
