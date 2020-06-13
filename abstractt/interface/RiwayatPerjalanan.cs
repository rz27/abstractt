using System;
namespace abstractt.@interface
{
    public class RiwayatPerjalanan : IdataPasienC , Ikeluhan
    {

        public void DataUmum()
        {
            Console.WriteLine("Dari Jakarta");
        }

        public void keluhann()
        {
            Console.WriteLine("Merasa pusing dan sedikit sesak Nafas");
        }
    }
}
