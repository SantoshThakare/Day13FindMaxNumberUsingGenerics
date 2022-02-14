using FindMaximumProblem;
using NUnit.Framework;

namespace Test1MaxNumber
{
    public class Tests
    {
        int[] intArray =  { 1, 2, 3 };
        double[] doubleArray = { 1d, 2d, 3d };
        string[] stringArray = { "HCl", "Tcs", "Infosys" };

        
        


        [Test]
        public void FirstPositionMaxInt1()
        {
            FindMax<int> Maxint = new FindMax<int>(intArray);

            int max = Maxint.ReturnMax(5, 4, 3, 2);
            Assert.AreEqual(5, max);
        }

        [Test]
        public void SecondPositionMaxInt2()
        {
            FindMax<int> Maxint = new FindMax<int>(intArray);

            int max = Maxint.ReturnMax(4, 5, 3, 2);
            Assert.AreEqual(5, max);
        }
        [Test]
        public void ThirdPositionMaxInt3()
        {
            FindMax<int> Maxint = new FindMax<int>(intArray);
            int max = Maxint.ReturnMax(3, 4, 5, 2);
            Assert.AreEqual(5, max);
        }
        [Test]
        public void FourthPositionMaxInt4()
        {
            FindMax<int> Maxint = new FindMax<int>(intArray);
            int max = Maxint.ReturnMax(3, 4, 2, 5);
            Assert.AreEqual(5, max);
        }
            [Test]
        public void FirstPositionMaxDouble1()
        {
            FindMax<double> Maxdouble = new FindMax<double>(doubleArray);
            double max = Maxdouble.ReturnMax(5.5d, 4.4d, 3.3d, 2.2d);
            Assert.AreEqual(5.5d, max);
        }

        [Test]
        public void SecondPositionMaxDouble2()
        {
            FindMax<double> Maxdouble = new FindMax<double>(doubleArray);
            double max = Maxdouble.ReturnMax(4.4d, 5.5d, 3.3d,2.2d );
            Assert.AreEqual(5.5d, max);
        }
        [Test]
        public void ThirdPositionMaxDouble3()
        {
            FindMax<double> Maxdouble = new FindMax<double>(doubleArray);
            double max = Maxdouble.ReturnMax(3.2d, 4.4d, 5.5d, 2.2d);
            Assert.AreEqual(5.5, max);
        }
        [Test]
        public void FourthPositionMaxDouble4()
        {
            FindMax<double> Maxdouble = new FindMax<double>(doubleArray);
            double max = Maxdouble.ReturnMax(3.2d, 4.4d, 2.2d, 5.5d);
            Assert.AreEqual(5.5, max);
        }
        [Test]
        public void FirstPositionMaxString1()
        {
            FindMax<string> Maxstring = new FindMax<string>(stringArray);
            string max = Maxstring.ReturnMax("TechMahindra", "Infosys", "HCL" , "TCS");
            Assert.AreEqual("TechMahindra", max);
        }

        [Test]
        public void SecondPositionMaxString2()
        {
            FindMax<string> Maxstring = new FindMax<string>(stringArray);
            string max = Maxstring.ReturnMax("Infosys", "TechMahindra", "HCL", "TCS");
            Assert.AreEqual("TechMahindra", max);
        }
        [Test]
        public void ThirdPositionMaxStr3()
        {
            FindMax<string> Maxstring = new FindMax<string>(stringArray);
            string max = Maxstring.ReturnMax("HCL", "Infosys", "TechMahindra","TCS");
            Assert.AreEqual("TechMahindra", max);
        }
        public void FourthPositionMaxStr4()
        {
            FindMax<string> Maxstring = new FindMax<string>(stringArray);
            string max = Maxstring.ReturnMax("HCL", "Infosys", "TCS", "TechMahindraCS");
            Assert.AreEqual("TechMahindra", max);
        }
    }
}