using FindMaximumProblem;
using NUnit.Framework;

namespace TestMaxNumber
{
    public class Tests
    {
        FindMax<int> Maxint = new FindMax<int>();
        FindMax<double> Maxdouble = new FindMax<double>();
        FindMax<string> Maxstring = new FindMax<string>();

        [Test]
        public void FirstPositionMaxInt1()
        {
            FindMax find = new FindMax();
            int max = find.ReturnMax(5, 4, 3);
            Assert.AreEqual(5, max);
        }

        [Test]
        public void SecondPositionMaxInt2()
        {
            FindMax find = new FindMax();
            int max = find.ReturnMax(4, 5, 3);
            Assert.AreEqual(5, max);
        }
        [Test]
        public void ThirdPositionMaxInt3()
        {
            FindMax find = new FindMax();
            int max = find.ReturnMax(3, 4, 5);
            Assert.AreEqual(5, max);
        }
        [Test]
        public void FirstPositionMaxDouble1()
        {
            FindMax find = new FindMax();
            double max = find.ReturnMax(5.5d, 4.4d, 3.2d);
            Assert.AreEqual(5.5d, max);
        }

        [Test]
        public void SecondPositionMaxDouble2()
        {
            FindMax find = new FindMax();
            double max = find.ReturnMax(4.4d, 5.5d, 3.2d);
            Assert.AreEqual(5.5d, max);
        }
        [Test]
        public void ThirdPositionMaxDouble3()
        {
            FindMax find = new FindMax();
            double max = find.ReturnMax(3.2d, 4.4d, 5.5d);
            Assert.AreEqual(5.5, max);
        }
        [Test]
        public void FirstPositionMaxString1()
        {
            FindMax find = new FindMax();
            string max = find.ReturnMax("TechMahindra", "Infosys", "HCL");
            Assert.AreEqual("TechMahindra", max);
        }

        [Test]
        public void SecondPositionMaxString2()
        {
            FindMax find = new FindMax();
            string max = find.ReturnMax("Infosys", "TechMahindra","HCL");
            Assert.AreEqual("TechMahindra", max);
        }
        [Test]
        public void ThirdPositionMaxString3()
        {
            FindMax find = new FindMax();
            string max = find.ReturnMax("HCL", "Infosys", "TechMahindra");
            Assert.AreEqual("TechMahindra", max);
        }
    }
}