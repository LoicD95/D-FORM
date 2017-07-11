namespace D_Form
{
    public class Section
    {
        private string title;
        private Section _section;
        private QuestionBase _questionBase;

        public Section()
        {

        }

        public string Title { get; set; }
        public QuestionBase QuestionBase { get; set; }
        //public Section Section { get; set; }
    }
}