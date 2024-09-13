using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Pass
    {
        public int CheckPassword(string password)
        {
            int score = 0;

            if (password.Any(char.IsDigit)) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(ch => !char.IsLetterOrDigit(ch))) score++;
            if (password.Length > 10) score++;

            return score;   
        }
    }
}
