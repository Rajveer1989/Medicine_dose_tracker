using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MedicalRecord
{
   public static class session
    {
       public static string Username { get; private set; }
       public static void CreateSession(string _username)
       {
           Username = _username;
       }
       public static void DestroySession()
       {
           Username = null;
       }
    }
   public static class LoginDetails
   {
       public static bool Isvalidate(string username, string password)
       {
           SqlConnection con = new SqlConnection(Connectionstrings.ConString);
           //string cmdtext = "Select userid,password from users where userid='" + txtuserid.Text + "' and '" + txtpassword.Text + "'";
           SqlCommand cmd = new SqlCommand();
           cmd.CommandText = "Select userid,password from users where userid='" + username+ "' and password= '" + password + "'";
           cmd.Connection = con;
           con.Open();
           SqlDataReader dr = cmd.ExecuteReader();
           if (dr.HasRows)
           {
               if (dr.Read())
               {
                   return true;
               }
           }
           else
           {
               return false;
               
           }
           return false;
       }
   }
   public static class Database
   {
       public static string GetName(string userid)
       {
            string name = string.Empty;
            try
            {
               
                SqlConnection con = new SqlConnection(Connectionstrings.ConString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "_sp_GetName";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = userid.ToString();
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        name = dr["username"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error occured"); ;
            }
           return name;
       }
      


   }
}
