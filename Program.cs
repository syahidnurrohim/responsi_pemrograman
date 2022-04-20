using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lat
{
    internal class Program
    {
        public static void Main(string []args)
        {
            Karyawan kar1 = new Karyawan("199900", "Paijo", 2000000);
            Karyawan kar2 = new Karyawan("299900", "Jono", 3000000);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", kar1.NIK, kar1.Nama, kar1.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", kar2.NIK, kar2.Nama, kar2.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine("Kenaikan gaji sebesar 10%");
            Console.WriteLine();

            kar1.NaikkanGaji(10);
            kar2.NaikkanGaji(10);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", kar1.NIK, kar1.Nama, kar1.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", kar2.NIK, kar2.Nama, kar2.GajiBulanan);
        }
    }
}
