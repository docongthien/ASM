using ASM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase_ASM
{
    [TestFixture]
    public class Testtimkiem
    {
        private SinhvienService sv;
        [SetUp]
        public void Setup()
        {
            sv = new SinhvienService();
            var newsinhvien = new Sinhvien("1", "Nguyễn văn nam", "L01", "Lớp A", "SV001");
            sv.AddSinhVien(newsinhvien);
        }
        [Test]
        [TestCase("SV001")]
        [TestCase("SV002")]
        [TestCase("S")]
        [TestCase("SV")]
        [TestCase("SV0")]
        public void timkiemsinhvien(string masv)
        {
            var timkiem = sv.TimKiemMaSv(masv);
            try
            {
                Assert.AreEqual(1, timkiem.Count);
            }
            catch (ArgumentException)
            {
                Assert.Throws<ArgumentException>(() => sv.TimKiemMaSv(masv));
            }

        }
    }
}
