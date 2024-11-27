using ASM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase_ASM
{
    [TestFixture]
    public class Test_B5
    {
        private B5 bai5;
        [SetUp]
        public void Setup()
        {
            bai5 = new B5();
        }
        [Test]
        [TestCase(new int[] { },0,0)]
        [TestCase(new int[] { 1, 2, 3, 4 },2,3)]
        [TestCase(new int[] { 2, 2 }, 2,0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2,4)]
        [TestCase(new int[] { 1, 3, 7, 3, 2, 7, 10 }, -1,2)]
        public void TestB5(int[] arr2, int index, int value)
        {
            try
            {
                double ketqua = bai5.mang(arr2,index);
                Assert.AreEqual(value, ketqua);
            }
            catch (ArgumentException ex)
            {
                Assert.Throws<ArgumentException>(() => bai5.mang(arr2,index));
            }
        }
    }
}
