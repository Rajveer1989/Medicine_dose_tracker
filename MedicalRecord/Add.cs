using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalRecord
{
    public partial class Add : Form
    {
        int IDs = 0;
        string medicine = "";
        string dosage = "";
        string frequency = "";
        public Add()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Add New Medicine Record";
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
           

            txtmedicine.Focus();
        }
        public void GetID(int ID)
        {
            IDs = ID;
        }
        public void Getmedicine(string med)
        {
            medicine = med;
        }
        public void Getdosage(string dos)
        {
            dosage = dos;
        }
        public void Getfrequncy(string freq)
        {
            frequency = freq;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (IDs != 0)
            {
                txtmedicine.Text = medicine;
                txtfrequ.Text = frequency;
                txtdosabge.Text = dosage;
            }
        }
        public void UpdateData()
        {
            SqlConnection con = new SqlConnection(Connectionstrings.ConString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "update medicaltrack set Medicine_Name='" + txtmedicine.Text + "', Dosage='" + txtdosabge.Text + "',Frequency='" + txtfrequ.Text + "' where ID=" + IDs + "",
                CommandType = CommandType.Text,
                Connection = con
            };
            con.Open();
            int res = (int)cmd.ExecuteNonQuery();
            if (res == 1)
            {
                ClearData();
                MessageBox.Show("Data successfully updated !!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ViewRecord obj = new ViewRecord();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data not updated !!", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return;
            }
        }
       
        public void AddMedicineTrcaker()
        {
            try
            {
                SqlConnection con = new SqlConnection(Connectionstrings.ConString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into medicaltrack  (Medicine_Name,Dosage,Frequency,userid) values('" + txtmedicine.Text + "','" + txtdosabge.Text + "','" + txtfrequ.Text + "','"+session.Username+"') ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                int res = (int)cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    timer1.Start();
                    ClearData();
                    lblerror.ForeColor = Color.Green;
                    lblerror.Text = "Your Medicine data save successfully !";

                }
                else
                {
                        lblerror.ForeColor = Color.Red;
                        lblerror.Text = "Your Medicine data not saved";

                   
                }


            }
            catch (Exception)
            {
                
            }
        }
        public void ClearData()
        {
            txtdosabge.Clear();
            txtmedicine.Clear();
            txtfrequ.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmedicine.Text))
            {
                MessageBox.Show("Please fill medicine name !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmedicine.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtdosabge.Text))
            {
                MessageBox.Show("Please fill Dosage Quantity !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdosabge.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtfrequ.Text))
            {
                MessageBox.Show("Please fill Medicine Frequency !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfrequ.Focus();
                return;
            }
            else
            {
                if (session.Username != null)
                {
                    if (IDs == 0)
                    {
                        AddMedicineTrcaker();
                    }
                    else
                    {
                        UpdateData();
                    }
                }
                else
                {
                    MessageBox.Show("Your are signout please login again !", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblerror.Text = "";
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        public void DeleteData()
        {
            SqlConnection con = new SqlConnection(Connectionstrings.ConString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from medicaltrack where ID=" + IDs + "";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            int res = (int)cmd.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Delete successfully !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ViewRecord obj = new ViewRecord();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data not delete", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IDs > 0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want delete this record ?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    DeleteData();
                }
            }
            else
            {
                MessageBox.Show("Please select any record from view data form then  you can delete it.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
