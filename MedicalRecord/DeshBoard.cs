using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalRecord
{
    public partial class DeshBoard : Form
    {
       
        public DeshBoard()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowIcon = false;
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
                login obj = new login();
                obj.ShowDialog();
            }
           
                lblusername.Visible = true;
                lblusername.Text ="Welcome : "+ Database.GetName(session.Username);
           
            
        }
       

        private void DeshBoard_Activated(object sender, EventArgs e)
        {
            if (session.Username!= null)
            {
                label1.Text = "Welcome our New Store !";
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
                lblusername.Visible = true;
                lblusername.Text = "";
            }

            
        }
    }
}
