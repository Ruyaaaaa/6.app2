using System;

namespace _6.app2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //girilen iki sayının toplamı ve ekrana yazan program
            int sayi1, sayi2;
            Console.WriteLine("Lütfen 1. Sayiyi Giriniz");
            sayi1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 + sayi2;

            Console.WriteLine($"İki Sayinin Toplamının sonucu = {sonuc}");
            Console.WriteLine($"{sayi1} sayısı ile {sayi2} sayısının toplamı = {sonuc}");

            Console.WriteLine("Kapatmak için bir tusa basınız");
            Console.ReadKey();

            int sayi1, sayi2;
            Console.WriteLine("Lütfen 1. Sayiyi Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 - sayi2;

            Console.WriteLine($"İki Sayinin Farkının sonucu = {sonuc}");
            Console.WriteLine($"{sayi1} sayısı ile {sayi2} sayısının farkı = {sonuc}");

            Console.WriteLine("Kapatmak için bir tusa basınız");
            Console.ReadKey();

            int sayi1, sayi2;
            Console.WriteLine("Lütfen 1. Sayiyi Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 * sayi2;

            Console.WriteLine($"İki Sayinin Toplamının carpımı = {sonuc}");
            Console.WriteLine($"{sayi1} sayısı ile {sayi2} sayısının carpımı = {sonuc}");

            Console.WriteLine("Kapatmak için bir tusa basınız");
            Console.ReadKey();

            int sayi1, sayi2;
            Console.WriteLine("Lütfen 1. Sayiyi Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 / sayi2;

            Console.WriteLine($"İki Sayinin Bolumunun sonucu = {sonuc}");
            Console.WriteLine($"{sayi1} sayısı ile {sayi2} sayısının Bolumu = {sonuc}");

            Console.WriteLine("Kapatmak için bir tusa basınız");
            Console.ReadKey();













        }
    }
}
