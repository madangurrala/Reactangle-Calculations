using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestingAssignment1;


namespace TestingAssignment1_Tests
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void length_isEqual_with_Input() {

            //Arrange
            int l = 5;
            int w = 6;
            Rectangle rect = new Rectangle(l, w);
            //Act
            int length = rect.GetLength();

            //Assert
            Assert.AreEqual(length, l);

        }

    }
}
