using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace MedicalRecord
{
    public partial class login : Form
    {
        public static string Username = "";
       
        public login()
        {
            InitializeComponent();
            this.Text = "User Login";
            //this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            
        }
        private void login_Load(object sender, EventArgs e)
        {           

        }
        
        public bool UpdateLoginStatus(string userid)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connectionstrings.ConString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update users set login_status='login' where userid='" + userid + "'";
                cmd.CommandType = CommandType.Text;
                con.Open();
                int res = (int)cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }

        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (LoginDetails.Isvalidate(txtuserid.Text, txtpassword.Text))
            {
                bool loginstatus = UpdateLoginStatus(txtuserid.Text);
                if (loginstatus)
                {
                    usercreate.Lastloginuser(txtuserid.Text);
                    session.CreateSession(txtuserid.Text);
                    DeshBoard obj = new DeshBoard();
                    this.Hide();
                    // obj.Show();
                }
                else
                {
                    MessageBox.Show("login failed, try again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Invalid Login Details", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup obj = new Signup();
            this.Hide();
            obj.ShowDialog();
            obj.Focus();
        }

        private void txtuserid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtuserid.Text))
            {
                errorProvider1.SetError(txtuserid, "Please enter user id");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(txtuserid, "");
            }
        }

        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                errorProvider1.SetError(txtpassword, "Please enter password");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(txtpassword, "");
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (session.Username == null)
                {
                    Application.Exit();
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
