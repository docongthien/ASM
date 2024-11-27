using ASM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase_ASM
{
    [TestFixture]
    public class Test_B4
    {
        private B4 bai4;
        [SetUp]
        public void Setup()
        {
            bai4 = new B4();
        }
        [Test]
        [TestCase(new double[] {},3)]
        [TestCase(new double[] {1,2,3,4},2.5)]
        [TestCase(new double[] { 2, 2}, 2)]
        [TestCase(new double[] { 1, 2, 3, 4 },2)]
        [TestCase(new double[] { 1, 3, 7, 3, 2, 7, 10 }, 10)]
        public void TestB4(double[] arr2,double value)
        {
            try
            {
                double ketqua = bai4.mang(arr2);
                Assert.AreEqual(value, ketqua);
            }
            catch (ArgumentException ex) 
            {
                Assert.Throws<ArgumentException>(() => bai4.mang(arr2));
            }
        }
    }
}
