﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppövning
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdMemberLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string pw = txtPassword.Text;

            if(userName != "" || pw != "")
            {
                MessageBox.Show("Inloggning lyckades.");
            }
        }
    }
}
