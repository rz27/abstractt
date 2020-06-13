using System;
namespace abstractt.@interface
{
    public class Datadiri : IdataPasienC
    {
      
        public void DataUmum()
        {
            Console.WriteLine("Nama = Ahmad ");
            Console.WriteLine("Umur = 25 ");
            Console.WriteLine("Alamat = Cilacap Jawa Tengah ");
        }

        public void keluhan()
        {
            throw new NotImplementedException();
        }
    }
}
