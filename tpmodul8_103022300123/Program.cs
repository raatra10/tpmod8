﻿using System;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();

        config.UbahSatuan(); // Memanggil method ubah satuan

        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        double suhu = double.Parse(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hari = int.Parse(Console.ReadLine());

        bool suhuValid = false;

        if (config.satuan_suhu == "celcius")
            suhuValid = suhu >= 36.5 && suhu <= 37.5;
        else if (config.satuan_suhu == "fahrenheit")
            suhuValid = suhu >= 97.7 && suhu <= 99.5;

        if (suhuValid && hari < config.batas_hari_demam)
            Console.WriteLine(config.pesan_diterima);
        else
            Console.WriteLine(config.pesan_ditolak);
        Console.ReadLine();
    }
}
