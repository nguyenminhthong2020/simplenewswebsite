using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Models
{
    public class DataProvider
    {
        public static SqlConnection connectDB()
        {
            try
            {
                //SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = db_news; Integrated Security = True");
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FQHMPOFH\MSSQLSERVER01;Initial Catalog=db_news;Integrated Security=True");
                con.Open();
                return con;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable getList(string sQuery, SqlParameter[] paras)
        {
            SqlConnection con = connectDB();

            if (con == null)
            {
                return null;
            }

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sQuery, con);

                if (paras != null)
                {
                    da.SelectCommand.Parameters.AddRange(paras);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
        }


        public static int add(string iQuery, SqlParameter[] iParas)
        {
            SqlConnection con = connectDB();

            if (con == null)
            {
                return 0;
            }

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(iQuery, con);

                if (iParas != null)
                {
                    command.Parameters.AddRange(iParas);

                }
                da.InsertCommand = command;
                int result = command.ExecuteNonQuery();
                return result;
            }
            catch
            {
                return 0;
            }
        }


        public static int edit(string iQuery, SqlParameter[] iParas)
        {
            SqlConnection con = connectDB();

            if (con == null)
            {
                return 0;
            }

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(iQuery, con);

                if (iParas != null)
                {
                    command.Parameters.AddRange(iParas);

                }
                da.UpdateCommand = command;
                int result = command.ExecuteNonQuery();
                return result;
            }
            catch
            {
                return 0;
            }
        }


        public static int delete(string iQuery, SqlParameter[] iParas)
        {
            SqlConnection con = connectDB();

            if (con == null)
            {
                return 0;
            }

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(iQuery, con);

                if (iParas != null)
                {
                    command.Parameters.AddRange(iParas);

                }
                da.DeleteCommand = command;
                int result = command.ExecuteNonQuery();
                return result;
            }
            catch
            {
                return 0;
            }
        }
    }
}
