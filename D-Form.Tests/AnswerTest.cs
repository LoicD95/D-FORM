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

        }

        [Test]
        public void Find_Or_Create_Answer()
        {
            Form f = new Form();
            User u = new User("Sabrina");

            FormAnswer a = f.FindOrCreateAnswer("Sabrina");
            Assert.IsNotNull(a);
            FormAnswer b = f.FindOrCreateAnswer("Sabrina");
            Assert.AreSame(a,b);

        }
    }
}
