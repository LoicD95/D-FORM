using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Form
{
    public class OpenAnswer : AnswerBase
    {
        public string _freeAnswer;

        public OpenAnswer()
        {
            
        }

        public string FreeAnswer => _freeAnswer;

    }
}
