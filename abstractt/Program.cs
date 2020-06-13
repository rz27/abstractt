using System;

using abstractt.abstraction;
//using abstractt.@interface; //* menggunakan interface
namespace abstractt
{
    class Program
    {
        static void Main(string[] args)
        {
            dataPasienC dataPasienC;
            //IdataPasienC dataPasienC; //* menggunakan interface
            //Ikeluhan keluhan; //* menggunakan interface

            dataPasienC = new Datadiri();
            dataPasienC.DataUmum();


            dataPasienC = new RiwayatPerjalanan();
            dataPasienC.DataUmum();

            dataPasienC = new Keluhan();
            dataPasienC.DataUmum();

            //keluhan = new RiwayatPerjalanan(); //* menggunakan interface
            //keluhan.keluhann(); //* menggunakan interface


        }
    }
}
