using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;

namespace MedicalRecord
{
    static class Program
    {
        public static string path = @"Medical\username";
      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string username = GetUserName();
            Database.GetloginStatus(username);

            using (Mutex mutex=new Mutex(false,"Medicine"))
            {
                if(!mutex.WaitOne(500,false))
                {
                    MessageBox.Show("Application already running","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;

                }
                else
                {
                     Application.EnableVisualStyles();
                     Application.SetCompatibleTextRenderingDefault(false);
                     Application.Run(new wait());
                }
                
            }
           
        }
        public static string GetUserName()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path);
            string username = (string)key.GetValue("lastuser");
            key.Close();
            return username;
        }
    }
}
