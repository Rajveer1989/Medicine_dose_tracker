using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            }
            else
            {
                piclogin.Visible = false;
                piclogout.Visible = true;
            }

            //    lblusername.Visible = true;
            //    lblusername.Text ="Welcome : "+ Database.GetName(session.Username);


        }
       

        private void DeshBoard_Activated(object sender, EventArgs e)
        {
            label1.Text = "Welcome to Medicine Management !";
            if (session.Username!= null)
            {
              
                lblusername.Text = "Patient : " + Database.GetName(session.Username);
                piclogin.Visible = false;
                piclogout.Visible = true;
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
            session.DestroySession();
            if (session.Username == null)
            {
                piclogout.Visible = false;
                piclogin.Visible = true;
                lblusername.Visible = true;
                lblusername.Text = "";
                lblsignout.ForeColor = Color.Green;
                lblsignout.Text = "You have successfully logout !!";

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
    }
}
