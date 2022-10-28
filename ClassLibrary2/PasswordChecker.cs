using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary2
{
    public class PasswordChecker
    {
        public int PswdStrench(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return 0;
            }

            int res = 0;

            if (password.Length > 7)
                res += 1;
            if (Regex.Match(password, "[a-z]").Success)
                res += 1;
            if (Regex.Match(password, "[A-Z]").Success)
                res += 1;
            if (Regex.Match(password, "[0-9]").Success)
            {
                res++;
            }
            if (Regex.Match(password,
                   "[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)\\{\\}\\[\\]\\:\\'\\;\\\"\\/\\?\\.\\>\\,\\<\\~\\`\\-\\\\_\\=\\+\\|]").Success)
            {
                res++;
            }

            return res;
        }
    }
}
