using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    internal class Program
    {
        public static void Main(string []args)
        {
            Karyawan karyawan1 = new Karyawan("199900", "Paijo", 2000000);
            Karyawan karyawan2 = new Karyawan("299900", "Jono", 3000000);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine("Kenaikan gaji sebesar 10%");
            Console.WriteLine();

            karyawan1.NaikkanGaji(10);
            karyawan2.NaikkanGaji(10);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.ReadKey();
        }
    }
}
