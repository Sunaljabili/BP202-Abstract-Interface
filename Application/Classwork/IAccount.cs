using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    interface IAccount
    {
        bool PasswordChecked(string pass);
        void ShowInfo();
    }
}
