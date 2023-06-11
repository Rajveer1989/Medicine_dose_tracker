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
    public partial class ViewRecord : Form
    {
        public static int IDs = 0;
        public static string medicine = "";
        public static string dosage = "";
        public static string frequency = "";

        public ViewRecord()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadData()
        {
            SqlConnection con = new SqlConnection(Connectionstrings.ConString);

            string cmd = "select ID, Medicine_name,Dosage,Frequency from medicaltrack where userid='" + session.Username + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }
        private void ViewRecord_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDs = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            medicine = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dosage = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            frequency = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (!string.IsNullOrEmpty(medicine) && !string.IsNullOrEmpty(dosage) && !string.IsNullOrEmpty(frequency) && IDs != 0)
            {
                Add add = new Add();
                add.GetID(IDs);
                add.Getmedicine(medicine);
                add.Getfrequncy(frequency);
                add.Getdosage(dosage);
                this.Hide();
                add.ShowDialog();
            }

        }
    }
}
