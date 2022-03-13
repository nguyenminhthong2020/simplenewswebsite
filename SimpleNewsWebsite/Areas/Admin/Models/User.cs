using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Areas.Admin.Models
{
    public class UserInfo
    {
        private static string _Username;
        private static string _Password;
        private static bool _Check;

        public static string Username { get => _Username; set => _Username = value; }
        public static string Password { get => _Password; set => _Password = value; }
        public static bool Check { get => _Check; set => _Check = value; }
    }
}
