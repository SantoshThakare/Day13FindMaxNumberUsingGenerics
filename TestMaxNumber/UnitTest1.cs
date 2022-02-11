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
            int max = find.ReturnMax(5, 4, 3);
            Assert.AreEqual(5, max);
        }

        [Test]
        public void SecondPositionMax()
        {
            FindMax find = new FindMax();
            int max = find.ReturnMax(4, 5, 3);
            Assert.AreEqual(5, max);
        }
        [Test]
        public void ThirdPositionMax()
        {
            FindMax find = new FindMax();
            int max = find.ReturnMax(3, 4, 5);
            Assert.AreEqual(5, max);
        }
    }
}