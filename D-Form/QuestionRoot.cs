using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Form
{
    public class QuestionRoot : QuestionBase
    {
        readonly Form _form;

        internal QuestionRoot(Form f)
            : base()
        {
            Debug.Assert(f != null);
            _form = f;
        }

        public override Form Form => _form;

        protected internal override AnswerBase CreateAnswer() => null;
    }
}
