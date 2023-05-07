using System;

namespace Residence
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] vect = new Student[10];

            Console.Write("How many rooms will be rented (1 to 10): ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter email: ");
                string email = Console.ReadLine();
                Console.Write("Room number: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Student(name, email);

            }

            Console.WriteLine();
            Console.WriteLine("Rented Rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}