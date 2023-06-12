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
    public partial class wait : Form
    {
        private BackgroundWorker _worker;
        public wait()
        {
            InitializeComponent();
            _worker = new BackgroundWorker();
            _worker.DoWork += _worker_DoWork;
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            _worker.WorkerReportsProgress = true;
            _worker.WorkerSupportsCancellation = true;

        }

        void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
               
                // lblstatus.Text = "";
            }
            else if (e.Error != null)
            {

              
            }
            else
            {

                DeshBoard obj = new DeshBoard();
                this.Hide();
                obj.Show();

            }
        }

        void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.ForeColor = Color.White;
            label1.Text = "Please wait ..." + progressBar1.Value.ToString()+"%";
        }

        void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 50; i++)
            {
                Thread.Sleep(100);
                _worker.ReportProgress(i*2);               
            }
        }

        private void wait_Load(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }
    }
}
