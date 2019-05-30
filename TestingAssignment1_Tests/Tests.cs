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

        [Test]

        public void Set_Length_Testing()
        {
            //Arrange
            int l = 5;
            int w = 6;
            Rectangle rect = new Rectangle(l, w);
            //Act
            int length = rect.SetLength(5);

            //Assert
            Assert.AreEqual(length, l);
        }

        [Test]
        public void Get_Width_Testing()
        {
            //Arrange
            int l = 15;
            int w = 27;
            Rectangle rect = new Rectangle(l, w);
            //Act
            int width = rect.GetWidth();

            //Assert
            Assert.AreEqual(width, w);
        }

        [Test]
        public void Set_Width_Testing()
        {
            //Arrange
            //int l = 34;
            //int w = 56;
            Rectangle rect = new Rectangle(34, 56);
            //Act
            int width = rect.GetWidth();

            //Assert
            Assert.AreEqual(width, 56);
        }

        [Test]
        public void Get_Perimeter_Testing()
        {
            //Arrange
            int l = 34;
            int w = 56;
            Rectangle rect = new Rectangle(l, w);
            //Act
            int permiter = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(permiter, 180);
        }

        [Test]
        public void Get_Area_Testing()
        {
            //Arrange
            int l = 34;
            int w = 87;
            Rectangle rect = new Rectangle(l, w);
            //Act
            int area = rect.GetArea();

            //Assert
            Assert.AreEqual(area, 2958);
        }

    }
}
