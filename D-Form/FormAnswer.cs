using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Form
{
     public class FormAnswer
     {
        public User _user;
        public FormAnswer(string userName)
        {
            _user._name = userName;
        }

         public User User
         {
             get => _user;
             set => _user = value;
         }
    }
}
