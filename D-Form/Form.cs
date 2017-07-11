using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Form
{
    public class Form
    {
        private Section _section;
        private string _title;
        private List<AnswerBase> _answers;

        public Form()
        {
           
        }

        public Section Section => _section;

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public FormAnswer FinOrCreateAnswer(string userName)
        {
            FormAnswer n = new FormAnswer(userName);
            return n;
        }
    }
}
