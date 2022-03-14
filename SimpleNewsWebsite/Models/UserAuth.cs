using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Models
{
    public class UserAuth
    {
        private string _Username;
        private string _Password;

        private int _Role;
        private int _Status;
        private string _Check;

        public string Username { get => _Username; set => _Username = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Check { get => _Check; set => _Check = value; }
        public int Role { get => _Role; set => _Role = value; }
        public int Status { get => _Status; set => _Status = value; }

        public UserAuth(string username, string pass, int role, int status, string check)
        {
            _Username = username;
            _Password = pass;
            _Role = role;
            _Status = status;
            _Check = check;
        }

        public static UserAuth validate(string username, string password)
        {
            byte[] buffer = System.Text.Encoding.Unicode.GetBytes(password);
            string passBase64 = Convert.ToBase64String(buffer);
            string passMd5 = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(passBase64))).Replace("-", "");

            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@Mem_UName", username);
            paras[1] = new SqlParameter("@Mem_Pas", passMd5);

            DataTable dt = DataProvider.getList(@"
            SELECT TOP (1) [Mem_UName]
                  ,[Mem_Pas]
                  ,[Mem_Role]
                  ,[Mem_Status]
              FROM [db_news].[dbo].[Member]
              WHERE [Mem_UName] = @Mem_UName AND [Mem_Pas] = @Mem_Pas
            ", paras);

            if (dt.Rows.Count == 0)
                return null;

            UserAuth u = new UserAuth(
                dt.Rows[0]["Mem_UName"].ToString(),
                dt.Rows[0]["Mem_Pas"].ToString(),
                Convert.ToInt32(dt.Rows[0]["Mem_Role"]),
                Convert.ToInt32(dt.Rows[0]["Mem_Status"]),
                "true"
                );
            return u;
        }
    }
}
