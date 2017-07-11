using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace D_Form.Tests
{
    [TestFixture]
    public class AnswerTest
    {
        [Test]
        public void Create_Answer()
        {
            Form f = new Form();
            Assert.IsNull(f.Title);
            f.Title = "yo";
            Assert.AreEqual(f.Title, "yo");

            FormAnswer a = f.FinOrCreateAnswer("Loïc");
            Assert.IsNotNull(a);

        }
    }
}
