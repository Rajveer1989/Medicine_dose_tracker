using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalRecord
{
   public static class encryptPassword
    {
       public static string EncryptedPassword(string pwd)
       {
           return Convert.ToBase64String(System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(pwd)));
       }

    }
   public static class usercreate
   {
      public static string path = @"Medical\username";
       public static void Lastloginuser(string userid)
       {

           RegistryKey key = Registry.CurrentUser.CreateSubKey(path);

           key.SetValue("lastuser", userid);
           key.Close();

       }
   }
}
