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
    public partial class Add : Form
    {
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

        private void Add_Load(object sender, EventArgs e)
        {
            
        }

        private void txtmedicine_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtmedicine.Text))
            {
                errorProvider1.SetError(txtmedicine, "Please Enter Medicine Name!");
                e.Cancel = true;
            }

        }

        private void txtdosabge_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtdosabge.Text))
            {
                errorProvider1.SetError(txtdosabge, "Please Enter dosage!");
                e.Cancel = true;
            }

        }

        private void txtfrequ_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtfrequ.Text))
            {
                errorProvider1.SetError(txtfrequ, "Please Enter dosage frequency!");
                e.Cancel = true;
            }
        }

        private void txtmedicine_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtmedicine, "");
        }

        private void txtdosabge_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtdosabge, "");

        }

        private void txtfrequ_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtfrequ, "");

        }
    }
}
