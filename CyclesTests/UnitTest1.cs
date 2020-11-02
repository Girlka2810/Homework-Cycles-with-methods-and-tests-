using NUnit.Framework;
using Cycles;
namespace CyclesTests
{
    public class Tests
    {
        [TestCase(2,2,4)]
        [TestCase(2, 3, 8)]
        [TestCase(2, 0, 1)]
        [TestCase(5, 2, 25)]
        [TestCase(11, 2, 121)]
        public void PowerATest(int a,int b, int expected)
        {
            int actual = Cycles.RaiseAintoB.PowerA(a, b);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(250, "250  500  750  1000  ")]
        [TestCase(500,"500  1000  ")]
        [TestCase(200, "200  400  600  800  1000  ")]
        [TestCase(550, "550  ")]
        [TestCase(100, "100  200  300  400  500  600  700  800  900  1000  ")]
        public void FindingNumbersTest (int a, string expected)
        {
            string actual = Cycles.FindNumbersDivededInrange1To1000OnEnteredNumber.ShowNumbers(a);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(2,1)]
        [TestCase(4,2 )]
        [TestCase(100, 10)]
        [TestCase(25, 5)]
        public void PowLessATest(int a, int expected)
        {
            int actual = Cycles.FindNumbersPowLessThanA.QuantityOfNumbers(a);
                        Assert.AreEqual(actual, expected);
        }
        [TestCase(100, 50)]
        [TestCase(15,5)]
        [TestCase(123546, 61773)]
        [TestCase(25, 5)]
        public void  NODTest(int a, int expected)
        {
            int actual = Cycles.FindNOD.ShowNOD(a);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(10,500, "����� ����� � ��������� �� 10 �� 500 : 17885")]
        [TestCase(1254, 123, "����� ����� � ��������� �� 123 �� 1254 : 111699")]
        [TestCase(456,5698, "����� ����� � ��������� �� 456 �� 5698 : 2306920")]
        [TestCase(0,25, "����� ����� � ��������� �� 0 �� 25 : 42")]
        public void DevidingTo7Test(int a, int b, string expected)
        {
            string actual = Cycles.FindQuantityOfAllNumbersInRangeAToBDevidedTo7.SumOfNumbersDevidedTo7(a,b);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(10, "10-�� ����� ���� ���������: 55")]
        [TestCase(3, "3-�� ����� ���� ���������: 2")]
        [TestCase(56, "56-�� ����� ���� ���������: -1781832971")]
        [TestCase(25, "25-�� ����� ���� ���������: 75025")]
        public void FibonachiTest(int a, string expected)
        {
            string actual = Cycles.FindFibonachiNumber.FibonachiNumber(a);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(100,5, "���������� �������� ����� 100 � 5 : 5 ")]
        [TestCase(5,100, "���������� �������� ����� 5 � 100 : 5 ")]
        [TestCase(45, 784, "���������� �������� ����� 45 � 784 : 1 ")]
        [TestCase(152,2564, "���������� �������� ����� 152 � 2564 : 4 ")]
        public void AlgoritmEvklidaTest(int a,int b, string expected)
        {
            string actual = Cycles.AlgorithmEvklida.SolutionOfEvklid(a,b);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(27, 3.00000062584877)]
        [TestCase(625, 8.54987942148)]
        [TestCase(425, 7.518473686650395)]
        [TestCase(725, 8.983508800156415)]
        public void CubicRootTest(double n, double expected)
        {
            double actual = Cycles.FindCubicRoot.SolutionOfCubicRoot(n);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(123456,3)]
        [TestCase(2468,0)]
        [TestCase(13579,5)]
        [TestCase(2574,2)]
        public void OddNumberTest(int a, int expected)
        {
            double actual = Cycles.OddNumberInNumber.FindQuantOfOddNumber(a);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(123,321)]
        [TestCase(4589,9854)]
        [TestCase(874521,125478)]
        [TestCase(2574, 4752)]
        public void MirrorSortTest(int a, int expected)
        {
            int actual = Cycles.MirrorSort.ChangePositionsOfNum(a);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(23,10 )]
        [TestCase(14235,5174 )]
        [TestCase(764859, 283327)]
        [TestCase(54637012, 19758731)]
        [TestCase(15,6 )]
                public void SumEvenNumbTest(int a, int expected)
        {
            int actual = Cycles.SumOfEvenNumberBigerThanSumOfOddNum.SumEvenNumMore(a);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(100, 5, "No")]
        [TestCase(5234, 316780, "Yes")]
        [TestCase(45, 784, "Yes")]
        [TestCase(190, 2564, "No")]
        [TestCase(2564, 190, "No")]
        [TestCase(196, 2564, "Yes")]
        [TestCase( 2564,196, "Yes")]
        [TestCase(190, 784562, "No")]
        [TestCase(98723, 45678, "Yes")]
        public void SameNumbersTest(int a, int b, string expected)
        {
            string actual = Cycles.FindTheSameNumber.InformAboutSameNumber(a, b);
            Assert.AreEqual(actual, expected);
        }
    }


}