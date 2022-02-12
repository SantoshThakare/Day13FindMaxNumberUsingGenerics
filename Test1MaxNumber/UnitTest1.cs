using FindMaximumProblem;
using NUnit.Framework;

namespace Test1MaxNumber
{
    public class Tests
    {
        FindMax<int> Maxint = new FindMax<int>();
        FindMax<double> Maxdouble = new FindMax<double>();
        FindMax<string> Maxstring = new FindMax<string>();


        [Test]
        public void FirstPositionMaxInt1()
        {


            int max = Maxint.ReturnMax(5, 4, 3);
            Assert.AreEqual(5, max);
        }

        [Test]
        public void SecondPositionMaxInt2()
        {

            int max = Maxint.ReturnMax(4, 5, 3);
            Assert.AreEqual(5, max);
        }
        [Test]
        public void ThirdPositionMaxInt3()
        {

            int max = Maxint.ReturnMax(3, 4, 5);
            Assert.AreEqual(5, max);
        }
        [Test]
        public void FirstPositionMaxDouble1()
        {

            double max = Maxdouble.ReturnMax(5.5d, 4.4d, 3.2d);
            Assert.AreEqual(5.5d, max);
        }

        [Test]
        public void SecondPositionMaxDouble2()
        {

            double max = Maxdouble.ReturnMax(4.4d, 5.5d, 3.2d);
            Assert.AreEqual(5.5d, max);
        }
        [Test]
        public void ThirdPositionMaxDouble3()
        {

            double max = Maxdouble.ReturnMax(3.2d, 4.4d, 5.5d);
            Assert.AreEqual(5.5, max);
        }
        [Test]
        public void FirstPositionMaxString1()
        {

            string max = Maxstring.ReturnMax("TechMahindra", "Infosys", "HCL");
            Assert.AreEqual("TechMahindra", max);
        }

        [Test]
        public void SecondPositionMaxString2()
        {

            string max = Maxstring.ReturnMax("Infosys", "TechMahindra", "HCL");
            Assert.AreEqual("TechMahindra", max);
        }
        [Test]
        public void ThirdPositionMaxStr3()
        {
            string max = Maxstring.ReturnMax("HCL", "Infosys", "TechMahindra");
            Assert.AreEqual("TechMahindra", max);
        }
    }
}