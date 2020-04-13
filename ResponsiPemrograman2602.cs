using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2602
{
    public class karyawan
    {
        public string nik { get; set; }
        public string nama { get; set; }
        public int gaji { get; set;  }

        public karyawan(string nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;
            this.gaji = gaji;
            
            if(gaji<0)
            {
                gaji = 0;
            }
        }
        public void output()
        {

            Console.WriteLine("{0}     {1}         {2}", nik, nama, gaji);
        }
        public void naikgaji()
        {
            double gaji2 = 0, naikgj = 0;
            naikgj = 0.1 * gaji;
            gaji2 = gaji + naikgj;

            Console.WriteLine("{0}     {1}         {2}", nik, nama, gaji2);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            karyawan org1 = new karyawan( "001002003", "Damai", 2000000);
            karyawan org2 = new karyawan("001002004", "Patria", 3000000);

            Console.WriteLine("NIK           Nama          GajiBulanan");
            Console.WriteLine("---------------------------------------");
            org1.output(); 
            org2.output();
         
            Console.WriteLine("\nNIK           Nama          GajiBulanan");
            Console.WriteLine("---------------------------------------");
            org1.naikgaji();
            org2.naikgaji();
         


            Console.ReadKey();
        }
    }
}
