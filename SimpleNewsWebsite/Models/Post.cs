using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Models
{
    public class Post
    {
        private int _PosID;
        private string _PosTitle;
        private string _PosImg;
        private string _PosBrief;
        private string _PosContent;
        private string _PosMem;
        private int _PosCat;
        private DateTime? _PosCre;
        private DateTime? _PosEdit;
        private int? _PosStatus;

        public int PosID { get => _PosID; set => _PosID = value; }
        public string PosTitle { get => _PosTitle; set => _PosTitle = value; }
        public string PosImg { get => _PosImg; set => _PosImg = value; }
        public string PosBrief { get => _PosBrief; set => _PosBrief = value; }
        public string PosContent { get => _PosContent; set => _PosContent = value; }
        public string PosMem { get => _PosMem; set => _PosMem = value; }
        public int PosCat { get => _PosCat; set => _PosCat = value; }
        public DateTime? PosCre { get => _PosCre; set => _PosCre = value; }
        public DateTime? PosEdit { get => _PosEdit; set => _PosEdit = value; }
        public int? PosStatus { get => _PosStatus; set => _PosStatus = value; }

        public Post(int id, string title, string img, string brief, string content, string mem, int cat, DateTime? cre, DateTime? edit, int? status)
        {
            _PosID = id;
            _PosTitle = title;
            _PosBrief = brief;
            _PosCat = cat;
            _PosContent = content;
            _PosMem = mem;
            _PosStatus = status;
            _PosImg = img;
            _PosCre = cre;
            _PosEdit = edit;
        }


        /// <summary>
        /// get a post by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Post getPostById(int id)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@id", id);

            DataTable dt = DataProvider.getList(@"SELECT TOP (1) [Pos_ID]
                          ,[Pos_Title]
                          ,[Pos_Img]
                          ,[Pos_Brief]
                          ,[Pos_Content]
                          ,[Pos_Mem]
                          ,[Pos_Cat]
                          ,[Pos_Cre]
                          ,[Pos_Edit]
                          ,[Pos_Status]
            FROM[db_news].[dbo].[Post] WHERE [Pos_ID]= @id", paras);

            if (dt.Rows.Count == 0)
                return null;

            Post p = new Post(Convert.ToInt32(dt.Rows[0]["Pos_ID"]),
                dt.Rows[0]["Pos_Title"].ToString(),
                dt.Rows[0]["Pos_Img"].ToString(),
                dt.Rows[0]["Pos_Brief"].ToString(),
                dt.Rows[0]["Pos_Content"] == null ? "" : dt.Rows[0]["Pos_Content"].ToString(),
                dt.Rows[0]["Pos_Mem"].ToString(),
                Convert.ToInt32(dt.Rows[0]["Pos_Cat"]),
                dt.Rows[0].IsNull("Pos_Cre") ? (DateTime?)null : (DateTime?)dt.Rows[0]["Pos_Cre"],
                dt.Rows[0].IsNull("Pos_Edit") ? (DateTime?)null : (DateTime?)dt.Rows[0]["Pos_Edit"],
                dt.Rows[0].IsNull("Pos_Status") ? (int?)null : (int?)dt.Rows[0]["Pos_Status"]
                );
            return p;
        }


        /// <summary>
        /// get 'count' newest post (by time)
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<Post> getNewPostsByTime(int count1)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@count1", count1);

            DataTable dt = DataProvider.getList(@"
              SELECT TOP(4)
               [Pos_ID]
              ,[Pos_Title]
              ,[Pos_Img]
              ,[Pos_Brief]
              ,[Pos_Content]
              ,[Pos_Mem]
              ,[Pos_Cat]
              ,[Pos_Cre]
              ,[Pos_Edit]
              ,[Pos_Status]
            FROM [db_news].[dbo].[Post]
            ORDER BY [Pos_Cre] DESC
            ", paras);

            List<Post> lst = new List<Post>();
            foreach (DataRow dr in dt.Rows)
            {
                Post p = new Post(Convert.ToInt32(dr["Pos_ID"]),
                dr["Pos_Title"].ToString(),
                dr["Pos_Img"].ToString(),
                dr["Pos_Brief"].ToString(),
               dr["Pos_Content"] == null ? "" : dr["Pos_Content"].ToString(),
                dr["Pos_Mem"].ToString(),
                Convert.ToInt32(dr["Pos_Cat"]),
                dr.IsNull("Pos_Cre") ? (DateTime?)null : (DateTime?)dr["Pos_Cre"],
                dr.IsNull("Pos_Edit") ? (DateTime?)null : (DateTime?)dr["Pos_Edit"],
                dr.IsNull("Pos_Status") ? (int?)null : (int?)dr["Pos_Status"]
                );
                lst.Add(p);
            }

            return lst;
        }
    }
}
