using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Form
{
    public class FormAnswer
    {
        readonly Form _form;
        readonly string _userName;
        readonly Dictionary<QuestionBase, AnswerBase> _answers;

        internal FormAnswer(Form f, string userName)
        {
            _form = f;
            _userName = userName;
            _answers = new Dictionary<QuestionBase, AnswerBase>();
        }

        public string UserName => _userName;

        public Form Form => _form;

        public AnswerBase FindAnswer(QuestionBase q)
        {
            AnswerBase a;
            _answers.TryGetValue(q, out a);
            return a;
        }

        public AnswerBase FindOrCreateAnswer(QuestionBase q)
        {
            AnswerBase a;
            if (!_answers.TryGetValue(q, out a)) a = CreateAnswer(q);
            return a;
        }

        public AnswerBase CreateAnswer(QuestionBase q)
        {
            AnswerBase a = q.CreateAnswer();
            if (a != null) _answers.Add(q, a);
            return a;
        }

    }
}
