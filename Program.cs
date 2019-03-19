using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan2
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Mahasiswa
            Class1 saya = new Class1();
            Class1 kamu = new Class1();

            // mengeset nilai properties objek saya dan kamu
            saya.Nim = "18.11.2382";
            saya.Nama = "Prasetyo Adi N";
            saya.Ipk = 4.00f;

            kamu.Nim = "18.11.2317";
            kamu.Nama = "Suriyadi";
            kamu.Ipk = 0.50f;

            // memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
