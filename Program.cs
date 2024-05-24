﻿using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSmartphone Nokia:\n");
            Nokia nokia = new Nokia("(11) 9 1111-1111", "Nokia 12", "183708364816492", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone iPhone:\n");
            Iphone iphone = new Iphone("(22) 9 2222-2222", "iPhone 13", "7429462956364736", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
        }
    }
}
