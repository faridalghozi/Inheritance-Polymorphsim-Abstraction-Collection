using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Polymorphsim, Inheritance, Abstraction & Collection";
            Console.WriteLine("       Muhammad Farid Alghozi      ");
            Console.WriteLine("           19.11.2824            ");
            Console.WriteLine("");

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "2556223664321121";
            karyawanTetap.Nama = "Paijo Tukimin";
            karyawanTetap.GajiBulanan = 4300000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "1988851423465465";
            karyawanHarian.Nama = "Hartono Paimin";
            karyawanHarian.JumlahJamKerja = 10;
            karyawanHarian.UpahPerJam = 20000;

            Sales sales = new Sales();
            sales.Nik = "342112892765364";
            sales.Nama = "Tono Suradi";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
