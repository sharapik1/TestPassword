using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Check
{
    public class Password
    {
    
        public string TestPassword(string password)
        {
            if(password.Length >=5 && password.Length <= 10)
            {
                try
                {
                    if ((!(new Regex(@"\d").IsMatch(password))))
                        throw new Exception("Пароль не содержит цифр");
                    if ((!(new Regex(@"[a-z]").IsMatch(password))))
                        throw new Exception("Пароль не содержит букв");
                    if ((!(new Regex(@"[@#$!&]").IsMatch(password))))
                        throw new Exception("Пароль не содержит специальных символов");
                    if ((!(new Regex(@"[A-Z]").IsMatch(password))))
                        throw new Exception("Пароль не содержит заглавных букв");

                }
                catch(Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "Неподходящая длина пароля";
            }
            return "ОК";
        }
    }
}
