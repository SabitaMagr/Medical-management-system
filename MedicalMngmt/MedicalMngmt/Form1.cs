using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalMngmt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="medical" && txtPassword.Text=="pass")
            {
                Dashboard db=new Dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Username and Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void linkhideshow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkhideshow.Text=="Show")
            {
                linkhideshow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                linkhideshow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtUsername_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TermandCondition tc = new TermandCondition();
            tc.Show();
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbox.Checked==true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled=false;
        }
    }
}
