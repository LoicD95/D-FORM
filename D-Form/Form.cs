using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Form
{
    public class Form
    {
        readonly QuestionRoot _root;
        readonly Dictionary<string, FormAnswer> _answers;

        public Form()
        {
            _root = new QuestionRoot(this);
            _answers = new Dictionary<string, FormAnswer>();
        }

        /// <summary>
        /// Gets or sets the title of this form: it is the same as the <see cref="Questions"/> title.
        /// </summary>
        public string Title
        {
            get => _root.Title;
            set => _root.Title = value;
        }

        public QuestionRoot Questions => _root;

        public FormAnswer FindAnswers(string userName)
        {
            FormAnswer a;
            _answers.TryGetValue(userName, out a);
            return a;
        }

        public FormAnswer FindOrCreateAnswers(string userName)
        {
            FormAnswer a;
            if (!_answers.TryGetValue(userName, out a)) a = CreateAnswers(userName);
            return a;
        }

        public FormAnswer CreateAnswers(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName)) throw new ArgumentNullException(nameof(userName));
            FormAnswer a = new FormAnswer(this, userName);
            _answers.Add(userName, a);
            return a;
        }
    }
}
