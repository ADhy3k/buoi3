using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class SinhVien
    {
        private int maSV;

        public int MaSV
        {
            get { return maSV; }
            set
            {
                if (maSV > 0)
                    maSV = value;
                else maSV = 0;
            }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (hoTen != null)
                    hoTen = value;
            }
        }
        private double diemLT, diemTH;

        public double DiemTH
        {
            get { return diemTH; }
            set
            {
                if (diemTH > 0 && diemTH < 10)
                    diemTH = value;
                else diemTH = 0;
            }
        }

        public double DiemLT
        {
            get { return diemLT; }
            set
            {
                if (diemLT > 0 && diemLT < 10)
                    diemLT = value;
                else diemLT = 0;
            }
        }
        public SinhVien()
        {
            MaSV = 00001;
            HoTen = "Le Van A";
            DiemLT = 5;
            DiemTH = 6;
        }
        public SinhVien(int mSV, string hTen, double dLT, double dTH)
        {
            mSV = this.MaSV;
            hTen = this.HoTen;
            dLT = this.DiemLT;
            dTH = this.DiemTH;
        }
        public double TinhDTB()
        {
            return (DiemLT + DiemTH) / 2;
        }
        public void nhap()
        {
            Console.WriteLine("Moi nhap ma SV: ");
            maSV = int.Parse(Console.ReadLine());
            Console.WriteLine("Ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Diem LT: ");
            diemLT = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem TH: ");
            diemTH = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("MaSv\tHoten\tDiemLT\tDiemTH\tDiemTB");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",maSV,hoTen,diemLT,diemTH,TinhDTB());
        }
    }
}
