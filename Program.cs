using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, city, street;
            int num, n;
            Address ads;
            room R;
            House[] houses;
            Console.WriteLine("How many house do you want?");
            num = int.Parse(Console.ReadLine());
            houses = new House[num];
            for (int i = 0; i < houses.Length; i++)
            {
                Console.WriteLine("Please write the name of the house number {0}", i + 1);
                name = Console.ReadLine();
                Console.WriteLine("Please write the name of the city, name of the street, and house number {0}", i + 1);
                city = Console.ReadLine();
                street = Console.ReadLine();
                num = int.Parse(Console.ReadLine());
                ads = new Address(city, street, num);
                houses[i] = new House(name, ads);
            }
            Console.WriteLine("Which house would you like to find the average area per room? press the number of house 1 - " + houses.Length);
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The average area per room is: " + houses[num - 1].average());
            Console.WriteLine("Which one of the houses would you like to find the room with the largest area? press the number of house 1 - " + houses.Length);
            num = int.Parse(Console.ReadLine());
            houses[num - 1].biggestRoom().show();
            Console.WriteLine("Insert in which house do you want to look the type? press the number of house 1 -  " + houses.Length);
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("please insert the type of the room you looking for");
            name = Console.ReadLine();
            R = houses[num - 1].getARoom(name);
            if (R == null)
                Console.WriteLine("There are no room in this type.");
            else
                R.show();
            Console.WriteLine("Between which indexes of the houses do you want to compare? 1 - " + houses.Length);
            num = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            houses[num - 1].compare(houses[n - 1]).show();
            Console.WriteLine();
            Console.WriteLine("The list of the houses:");
            foreach (House item in houses)
                item.show();
        }
    }
}

