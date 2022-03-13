using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Models
{
    public class Category
    {
        private int _CatID;
        private string _CatName;
        private string _CatMem;
        private DateTime? _CatPre;
        private DateTime? _CatEdit;
        private int _CatStatus;

        public int CatID { get => _CatID; set => _CatID = value; }
        public string CatName { get => _CatName; set => _CatName = value; }
        public string CatMem { get => _CatMem; set => _CatMem = value; }
        public DateTime? CatPre { get => _CatPre; set => _CatPre = value; }
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
        public Category(int id, string name, string mem, DateTime? pre, DateTime? edit, int status)
        {
            _CatID = id;
            _CatName = name;
            _CatMem = mem;
            _CatPre = pre;
            _CatEdit = edit;
            _CatStatus = status;
        }


        public static List<Category> getAllCategory()
        {
            DataTable dt = DataProvider.getList(@"
            SELECT [Cat_ID]
                  ,[Cat_Name]
                  ,[Cat_Mem]
                  ,[Cat_Pre]
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
                                            dr["Cat_Pre"] == null ? Convert.ToDateTime(dr["Cat_Pre"]) : null,
                                            dr["Cat_Edit"] == null ? Convert.ToDateTime(dr["Cat_Edit"]) : null,
                                            Convert.ToInt32(dr["Cat_Status"]));

                lst.Add(cat);
            }
            return lst;
        }
    }
}
