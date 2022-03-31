using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class User:IAccount
    {
        public User(string email,string password)
        {
            Email = email;
            Password = password;
        }
        public string FullName;
        public string Email;
        public string Password;

        public bool PasswordChecked(string password)
        {
            if(password.Length>=8)
            {
                bool checkdigit = false;
                bool checklower = false;
                bool checkUpper = false;
                foreach (var item in password)
                {
                    if(char.IsDigit(item))
                    {
                        checkdigit = true;
                    }
                    else if(char.IsLower(item))
                    {
                        checklower = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        checkUpper = true;
                    }

                    if (checkdigit && checklower && checkUpper)
                    {
                        return true;
                    }

                }

            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"fullname: {FullName} | email: {Email}");
        }
    }
}
