using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Form
{
    /// <summary>
    /// Base class for all questions. It is a composite.
    /// </summary>
    public abstract class QuestionBase
    {
        readonly List<QuestionBase> _children;
        QuestionBase _parent;

        /// <summary>
        /// Initializer for <see cref="QuestionRoot"/>: there is no parent.
        /// This is internal so that external implementations must use the 
        /// constructor that requires a non null initial parent.
        /// </summary>
        internal QuestionBase()
        {
            _children = new List<QuestionBase>();
        }

        /// <summary>
        /// Initializes a question with an initial parent.
        /// </summary>
        /// <param name="parent">The initial parent. Must not be null.</param>
        protected QuestionBase(QuestionBase parent)
            : this()
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            _parent = parent;
        }

        /// <summary>
        /// Gets or sets the title of the question.
        /// </summary>
        public string Title { get; set; }

        public QuestionBase Parent
        {
            get => _parent;
            set
            {
                if (_parent != value)
                {
                    if (_parent != null)
                    {
                        _parent._children.Remove(this);
                    }
                    _parent = value;
                    if (_parent != null)
                    {
                        _parent._children.Add(this);
                    }
                }
            }
        }

        internal protected abstract AnswerBase CreateAnswer();

        public QuestionBase AddChild(string questionType)
        {
            Type tQuestion = Type.GetType(questionType);
            QuestionBase q = (QuestionBase)Activator.CreateInstance(tQuestion, this);
            _children.Add(q);
            return q;
        }

        public IReadOnlyList<QuestionBase> Children => _children;

        public void RemoveChild(QuestionBase c)
        {
            if (c.Parent == this) c.Parent = null;
        }

        public virtual Form Form => Parent?.Form;

        public int Index
        {

            get => _parent != null
                ? _parent._children.IndexOf(this)
                : -1;
            set
            {
                if (_parent == null) throw new InvalidOperationException("Parent is required.");
                if (value < 0 || value > _parent._children.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                int oldIdx = _parent._children.IndexOf(this);
                if (oldIdx != value)
                {
                    _parent._children.RemoveAt(oldIdx);
                    if (oldIdx > value)
                    {
                        _parent._children.Insert(value, this);
                    }
                    else
                    {
                        _parent._children.Insert(value - 1, this);
                    }

                }
            }
        }
    }
}
