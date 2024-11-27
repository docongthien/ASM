using ASM;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TestCase_ASM
{
    [TestFixture]
    public class SinhvienTest
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
        [TestCase("2", "Nguyen văn nam", "L01", "Lớp A", "SV002")]
        [TestCase("3", "Nguyễn văn namm", "L01", "Lớp A", "SV003")]
        [TestCase("4", "Nguyễn văn nammm", "L01", "Lớp A", "SV004")]
        [TestCase("5", "Nguyễn", "L01", "Lớp A", "SV005")]
        [TestCase("6", "Nguyễ", "L01", "Lớp A", "SV006")]
        [TestCase("7", "Nguy", "L01", "Lớp A", "SV007")]
        [TestCase("8", "Nguyễn văn nam", "L01", "Lớp A", "SV001")]
        [TestCase("9", "Nguyễn hoàng thanh", "L01", "Lớp A", "SV009")]
        [TestCase("10", "lê minh vy", "L01", "Lớp A", "SV010")]
        [TestCase("11", "s", "L01", "Lớp A", "SV011")]
        [TestCase("12", "Nguyễn văn nam", "L01", "Lớp A@", "SV012")]
        public void Addsinhvien( string Id,string HoTen, string MaLop,string TenLop,string MaSV)
        {
            var newsinhvien = new Sinhvien(Id, HoTen, MaLop, TenLop, MaSV);
            sv.AddSinhVien(newsinhvien);
            try
            {
                Assert.AreEqual(2,sv.sinhViens.Count);
            }
            catch(ArgumentException)
            {
                Assert.Throws<ArgumentException>(() => sv.AddSinhVien(newsinhvien));
            }
        }

    }
}
