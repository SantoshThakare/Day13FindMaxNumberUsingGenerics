using FindMaximumProblem;
using NUnit.Framework;

namespace TestMaxNumber
{
    public class Tests
    {
        [Test]
        public void FirstPositionMax()
        {
            FindMax find = new FindMax();
            double max = find.ReturnMax(5.5d, 4.4d, 3.2d);
            Assert.AreEqual(5.5d, max);
        }

        [Test]
        public void SecondPositionMax()
        {
            FindMax find = new FindMax();
            double max = find.ReturnMax(4.4d, 5.5d, 3.2d);
            Assert.AreEqual(5.5d, max);
        }
        [Test]
        public void ThirdPositionMax()
        {
            FindMax find = new FindMax();
            double max = find.ReturnMax(3.2d, 4.4d, 5.5d);
            Assert.AreEqual(5.5, max);
        }
    }
}