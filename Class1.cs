namespace _27oct1;
using System;

class Program
{
    static void Main(string[] args)
    {
        const string usernameCorect = "Amaris24";
        const string passwordCorect = "12345";

        bool autentificat = false;

        while (!autentificat)
        {
            Console.WriteLine("Introduceti username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Introduceti parola: ");
            string password = Console.ReadLine();

            if (username == usernameCorect && password == passwordCorect)
            {
                Console.WriteLine("Welcome , " + usernameCorect);
                autentificat = true;

            }
            else
            {
                Console.WriteLine("Authentication failed. Enter again");
            }
        }
    }
}
