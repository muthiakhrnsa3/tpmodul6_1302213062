namespace tpmodul6_1302213062;
using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(String[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - [Muthia Khairunnisa_PRAKTIKAN]");

        //test prekondisi
        //video = new SayaTubeVideo(null);
        //video = new SayaTubeVideo("Judul video dengan panjang lebih dari 100 karakter akan menghasilkan ContractException");

        for (int i = 0; i < 1000000000; i += 10000000)
        {
            video.IncreasePlayCount(10000000);
        }
        video.PrintVideoDetails();
    }
}