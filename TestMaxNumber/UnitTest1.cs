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
            string max = find.ReturnMax("TechMahindra", "Infosys", "HCL");
            Assert.AreEqual("TechMahindra", max);
        }

        [Test]
        public void SecondPositionMax()
        {
            FindMax find = new FindMax();
            string max = find.ReturnMax("Infosys", "TechMahindra","HCL");
            Assert.AreEqual("TechMahindra", max);
        }
        [Test]
        public void ThirdPositionMax()
        {
            FindMax find = new FindMax();
            string max = find.ReturnMax("HCL", "Infosys", "TechMahindra");
            Assert.AreEqual("TechMahindra", max);
        }
    }
}