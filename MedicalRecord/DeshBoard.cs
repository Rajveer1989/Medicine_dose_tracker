using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MedicalRecord
{
    public partial class DeshBoard : Form
    {
        ToolTip ToolTip = new ToolTip();
        public static string path = @"Medical\username";

        public delegate void RemoveText();
       
        public DeshBoard()
        {
            InitializeComponent();

            ToolTip.SetToolTip(piclogin, "Login");
            ToolTip.SetToolTip(piclogout, "Log out");           
            StartPosition = FormStartPosition.CenterScreen;
            this.MinimizeBox = false;
            this.MaximizeBox = false;           
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.White;
        }

       

        private void DeshBoard_Load(object sender, EventArgs e)
        {
            
            
        }
        private void DeshBoard_Shown(object sender, EventArgs e)
        {

            if (session.Username == null)
            {
                piclogin.Visible = true;
                piclogout.Visible = false;
                lblusername.Text = "";
                this.piclogin.Location = new System.Drawing.Point(956, 2);
            }
            else
            {
                piclogin.Visible = false;
                piclogout.Visible = true;
            }

            

        }
       

        private void DeshBoard_Activated(object sender, EventArgs e)
        {
            label1.Text = "Welcome to Medicine Management !";
            if (session.Username!= null)
            {
                picperson.Visible = true;              
                lblusername.Text = Database.GetName(session.Username);
                piclogin.Visible = false;
                piclogout.Visible = true;
            }
            
         
           
        }
        public void deletelastuser()
        {

            RegistryKey key = Registry.CurrentUser.OpenSubKey(path,true);

            key.DeleteValue("lastuser");
            key.Close();

        }
        public bool UpdateLoginStatus(string userid)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connectionstrings.ConString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update users set login_status='logout' where userid='" + userid + "'";
                cmd.CommandType = CommandType.Text;
                con.Open();
                int res = (int)cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    deletelastuser();
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session.Username == null)
            {
                login obj = new login();
                obj.ShowDialog();
            }
            else
            {
                Add obj = new Add();
                obj.ShowDialog();
            }
        }      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bool status = UpdateLoginStatus(session.Username);
            if (status)
            {
                session.DestroySession();
                if (session.Username == null)
                {
                    picperson.Visible = false;
                    piclogout.Visible = false;
                    piclogin.Visible = true;
                    lblusername.Visible = true;
                    lblusername.Text = "";
                    lblsignout.ForeColor = Color.Green;
                    this.piclogin.Location = new System.Drawing.Point(956, 2);
                    lblsignout.Text = "You have successfully logout !!";
                    timer1.Start();

                }
            }

            
        }
        public void DeleteText()
        {
            if (lblsignout.InvokeRequired)
            {
                lblsignout.Invoke(new RemoveText(DeleteText));
            }
            else
            {
                lblsignout.Text = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login obj = new login();
            piclogout.Visible = false;
            lblusername.Text = "";

            obj.ShowDialog();
        }

        private void picmedine_Click(object sender, EventArgs e)
        {
           
        }

        private void picview_Click(object sender, EventArgs e)
        {
            if (session.Username != null)
            {
                ViewRecord obj = new ViewRecord();
                obj.ShowDialog();
            }
            else
            {
                login obj = new login();
                obj.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (session.Username != null)
            {
                Add obj = new Add();
                obj.ShowDialog();
            }
            else
            {
                login obj = new login();
                obj.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (session.Username != null)
            {
                ViewRecord obj = new ViewRecord();
                obj.ShowDialog();
            }
            else
            {
                login obj = new login();
                obj.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblsignout.Text != null)
            {
                lblsignout.Text = "";
            }
        }

        private void DeshBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialof = MessageBox.Show("Are you sure you want close the application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialof == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
