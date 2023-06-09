using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedicalRecord
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //this.ShowInTaskbar = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void ClearAll()
        {
            txtconfirmpass.Clear();
            txtname.Clear();
            txtpass.Clear();
            txtuserid.Clear();
            
        }
        public void SaveData()
        {
            try
            {
                string date = DateTime.Now.ToString();
                DateTime created = Convert.ToDateTime(date);

                if (string.IsNullOrEmpty(txtname.Text))
                {
                    MessageBox.Show("Please enter name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtname.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txtuserid.Text))
                {
                    MessageBox.Show("Please enter userid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtuserid.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txtpass.Text))
                {
                    MessageBox.Show("Please enter password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtpass.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txtconfirmpass.Text))
                {
                    MessageBox.Show("Please enter Confirm password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtconfirmpass.Focus();
                    return;
                }

                if (!txtpass.Text.Equals(txtconfirmpass.Text))
                {
                    MessageBox.Show("password and Confirm password did not match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    //txtconfirmpass.Focus();
                }

                SqlConnection con = new SqlConnection(Connectionstrings.ConString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into Users values('" + txtuserid.Text + "','" + txtname.Text + "','" + txtconfirmpass.Text + "','"+date+"','"+null+"')";
                cmd.Connection = con;
                 con.Open();
                 int res = (int)cmd.ExecuteNonQuery();
                 if (res == 1)
                 {
                     button1.Visible = true;
                     lblerror.ForeColor = Color.Green;
                     lblerror.Text = "Succesfully completed user registration";
                     ClearAll();
                     this.Hide();
                     login obj = new login();
                     obj.Show();
                 }
                 else
                 {
                     lblerror.ForeColor = Color.Green;
                     lblerror.Text = "Succesfully completed user registration";
                 }
                
                

            }
            catch (Exception)
            {
                lblerror.ForeColor = Color.Red;
                lblerror.Text = "Error occured !";
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login obj = new login();
            obj.ShowDialog();
        }
    }
}
