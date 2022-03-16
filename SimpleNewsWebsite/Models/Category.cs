using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Models
{
    public class Category
    {
        private int _CatID;
        private string _CatName;
        private string _CatMem;
        private DateTime? _CatCre;
        private DateTime? _CatEdit;
        private int _CatStatus;

        public int CatID { get => _CatID; set => _CatID = value; }
        public string CatName { get => _CatName; set => _CatName = value; }
        public string CatMem { get => _CatMem; set => _CatMem = value; }
        public DateTime? CatCre { get => _CatCre; set => _CatCre = value; }
        public DateTime? CatEdit { get => _CatEdit; set => _CatEdit = value; }
        public int CatStatus { get => _CatStatus; set => _CatStatus = value; }

        /// <summary>
        /// Phương thức khởi tạo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="mem"></param>
        /// <param name="pre"></param>
        /// <param name="edit"></param>
        /// <param name="status"></param>
        public Category(int id, string name, string mem, DateTime? cre, DateTime? edit, int status)
        {
            _CatID = id;
            _CatName = name;
            _CatMem = mem;
            _CatCre = cre;
            _CatEdit = edit;
            _CatStatus = status;
        }


        public static List<Category> getAllCategory()
        {
            DataTable dt = DataProvider.getList(@"
            SELECT [Cat_ID]
                  ,[Cat_Name]
                  ,[Cat_Mem]
                  ,[Cat_Cre]
                  ,[Cat_Edit]
                  ,[Cat_Status]
              FROM [db_news].[dbo].[Category]
            ", null);

            //var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            //var date2 = new DateTime(2009, 5, 1, 8, 30, 52);
            //List<Category> lst = new List<Category>() {
            //    new Category(1, "name1", "admin", null, null, 1),
            //    new Category(2, "name2", "admin", date1, date2, 1)
            //};
            List<Category> lst = new List<Category>();
            foreach (DataRow dr in dt.Rows)
            {
                Category cat = new Category(Convert.ToInt32(dr["Cat_ID"]),
                                            dr["Cat_Name"].ToString(), dr["Cat_Mem"].ToString(),
                                            dr["Cat_Cre"] == null ? Convert.ToDateTime(dr["Cat_Cre"]) : null,
                                            dr["Cat_Edit"] == null ? Convert.ToDateTime(dr["Cat_Edit"]) : null,
                                            Convert.ToInt32(dr["Cat_Status"]));

                lst.Add(cat);
            }
            return lst;
        }

        /// <summary>
        /// check Category from input submit has exsist ?
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string checkCategoryExist(string name)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@name", name);

            DataTable dt = DataProvider.getList(@"
            SELECT [Cat_ID]
                  ,[Cat_Name]
                  ,[Cat_Mem]
                  ,[Cat_Cre]
                  ,[Cat_Edit]
                  ,[Cat_Status]
              FROM [db_news].[dbo].[Category]
              WHERE [Cat_Name] = @name
            ", paras);

            if (dt.Rows.Count == 0) return "no exist";
            return "exist";
        }


        public static int add(string name, bool status, string mem)
        {
            int _status = (status == true ? 1 : 0);
            SqlParameter[] paras = new SqlParameter[4];
            paras[0] = new SqlParameter("@cat_name", name);
            paras[1] = new SqlParameter("@cat_mem", mem);
            paras[2] = new SqlParameter("@cat_cre", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            paras[3] = new SqlParameter("@cat_status", _status);

            int result = DataProvider.add(@"
            insert into dbo.Category(Cat_Name, Cat_Mem, Cat_Cre, Cat_Edit, Cat_Status) 
            values(@cat_name, @cat_mem, @cat_cre, null, @cat_status)
            ", paras);

            if (result == 0) return 0;
            return result;
        }

        public static int edit(string id, string name, bool status, string mem)
        {
            int _status = (status == true ? 1 : 0);
            int _id = Convert.ToInt32(id);

            SqlParameter[] paras = new SqlParameter[5];
            paras[0] = new SqlParameter("@cat_name", name);
            paras[1] = new SqlParameter("@cat_mem", mem);
            paras[2] = new SqlParameter("@cat_edit", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            paras[3] = new SqlParameter("@cat_status", _status);
            paras[4] = new SqlParameter("@cat_id", _id);

            int result = DataProvider.edit(@"
            UPDATE dbo.Category
            SET Cat_Name = @cat_name, Cat_Mem = @cat_mem, Cat_Status = @cat_status, Cat_Edit = @cat_edit
            WHERE Cat_ID = @cat_id
            ", paras);

            if (result == 0) return 0;
            return result;
        }

        public static int delete(string id)
        {
            int _id = Convert.ToInt32(id);

            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@cat_id", _id);

            int result = DataProvider.delete(@"
            DELETE FROM dbo.Category
            WHERE Cat_ID = @cat_id
            ", paras);

            if (result == 0) return 0;
            return result;
        }
    }
}
