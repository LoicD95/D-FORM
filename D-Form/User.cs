using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Form
{
    public class User
    {
        public string _name;

        public User(string name)
        {
            _name = name;
        }

        public string Name => _name;
    }
}
