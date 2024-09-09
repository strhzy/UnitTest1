using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class PasswordCheck
    {
        public static int Checker(string password)
        {
            int score = 0;

            if (password.Any(char.IsDigit)) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(c => !char.IsLetterOrDigit(c))) score++;
            if (password.Length > 10) score++;

            return score;
        }
    }
}
