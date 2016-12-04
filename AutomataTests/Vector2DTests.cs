using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automata.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Automata.Geometry.Tests
{
    [TestClass()]
    public class Vector2DTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            Vector2D a = new Vector2D(1, 2);
            Vector2D b = new Vector2D(1, 2);
            Assert.IsTrue(a.Equals(b));
            Assert.IsTrue(b.Equals(a));
            Vector2D c = new Vector2D(2, 3);
            Vector2D d = new Vector2D(3, 2);
            Assert.IsFalse(c.Equals(d));
            Assert.IsFalse(d.Equals(c));
        }

        [TestMethod()]
        public void EqualsTest1()
        {
            Vector2D a = new Vector2D(1, 2);
            Vector2D b = new Vector2D(1, 2);
            Assert.IsTrue(a.Equals(b));
            Assert.IsTrue(b.Equals(a));
            //Vector2D c = new Vector2D(2, 3);
            //Assert.IsFalse(c.Equals(null));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Vector2D a = new Vector2D(1, 2);
            int b = a.GetHashCode();
            Assert.IsNotNull(b);
        }

        [TestMethod()]
        public void Vector2DTest()
        {
            Vector2D a = new Vector2D(1, 2);
            Assert.IsNotNull(a);
            Vector2D b = new Vector2D(1, 2);
            Vector2D c = a + b;
            Vector2D d = a - b;
            Vector2D e = a * 0.1f;
        }

        [TestMethod()]
        public void ToPointTest()
        {
            Vector2D a = new Vector2D(1, 2);
            Point b = a.ToPoint();
            Assert.IsNotNull(b);
            //Assert.Equals(b.X, 1);
            //Assert.Equals(b.Y, 2);

            Vector2D c = new Vector2D(1.2f, 2.7f);
            PointF d = c.ToPointF();
            Assert.IsNotNull(d);
            //Assert.Equals(d.X, 1);
            //Assert.Equals(d.Y, 2);
        }

        [TestMethod()]
        public void ToPointFTest()
        {
            Vector2D a = new Vector2D(1.2f, 2.7f);
            PointF b = a.ToPointF();
            Assert.IsNotNull(b);
            //Assert.Equals(b.X, 1.2d);
            //Assert.Equals(b.Y, 2.7d);

            Vector2D c = new Vector2D(1, 2);
            PointF d = c.ToPointF();
            Assert.IsNotNull(d);
            //Assert.Equals(d.X, 1.0d);
            //Assert.Equals(d.Y, 2.0d);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Vector2D a = new Vector2D(1, 2);
            Assert.IsNotNull(a.ToString());
        }
    }
}