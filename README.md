# Student Residence
## C# arrays project

The owner of a residence has ten rooms to rent to students, with the rooms identified by numbers 0 to 9.
When a student wishes to rent a room, the name and email of the student must be recorded.
Create a program that starts with all ten rooms empty, and then reads a quantity N representing the number of students who will rent rooms (N can be from 1 to 10). Then, register the rental of the N students. For each rental record, inform the name and email of the student, as well as which room they chose (from 0 to 9). Assume that an empty room is chosen. Finally, the program should print a report of all the residence's occupancies, in room order, as an example.

```Markdown
How many rooms will be rented (1 to 10): 3
Rent #1:
Name: Maria Green
Email: maria@gmail.com
Room number: 5

Rent #2:
Name: Marco Antonio
Email: marco@gmail.com
Room number: 1

Rent #3:
Name: Alex Brown
Email: alex@gmail.com
Room number: 8

Rented Rooms:
1: Marco Antonio, marco@gmail.com
5: Maria Green, maria@gmail.com
8: Alex Brown, alex@gmail.com
```

```C#
using System;

namespace Residence
{
    internal class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Student(string name, string email) 
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }

    }
}
```
```C#
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
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
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
```
