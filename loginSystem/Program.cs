using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Program
{
    static void Main()
    {
        string correctUser = "admin";
        string correctPass = "1234";
        int maxAttempts = 3;

        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            Console.Write("Kullanıcı Adı: ");
            string username = Console.ReadLine()!;

            Console.Write("Şifre: ");
            string password = Console.ReadLine()!;

            if (username == correctUser && password == correctPass)
            {
                Console.Clear();
                Console.WriteLine("Başarıyla giriş yaptınız!");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Hatalı giriş! {maxAttempts - attempt} hakkınız kaldı.");
                Thread.Sleep(1000);
                Console.Clear();
            }

            if (attempt == maxAttempts)
            {
                Console.Clear();
                Console.WriteLine("Tüm giriş haklarınızı tükettiniz. Sistemden çıkılıyor.");
                Thread.Sleep(100);
                Environment.Exit(0);
            }
        }
    }
}
