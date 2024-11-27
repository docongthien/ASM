﻿using ASM;

namespace TestCase_ASM
{
    [TestFixture]
    public class Test_B2
    {
        private B2 bai2;
        [SetUp]
        public void Setup()
        {
            bai2 = new B2();
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(3, 1, 5)]
        [TestCase(-1, 2, 3)]
        [TestCase(3, -1, 4)]
        [TestCase(9, 2, 11)]
        [TestCase(5, 5, 12)]
        [TestCase(11, 2, 13)]
        [TestCase(3, 11, 14)]
        [TestCase(1.5, 2, 3)]
        [TestCase(3, 1.5, 4)]
        public void TestB2(double a, double b, double value)
        {
            try
            {
                double tong = bai2.Tich2songuyen(a, b);
                Assert.AreEqual(tong, value);
            }
            catch (ArgumentException ex)
            {
                Assert.Throws<ArgumentException>(() => bai2.Tich2songuyen(a, b));
            }

        }
    }
}