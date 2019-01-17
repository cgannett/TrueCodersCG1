using System;

namespace Day3Review
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = GetFirstName();
            string lastName = GetLastName();
            string favoriteNumber = GetFavoriteNumber();
            string favoriteAnimal = GetFavoriteAnimal();
            string favoriteColor = GetFavoriteColor();


            Console.Clear();
            
            Console.WriteLine("Awesome! Here is your information:");
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.Write("Favorite Animal: ");
            Console.ForegroundColor = (favoriteAnimal.Length > 5) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine(favoriteAnimal);
            Console.ResetColor();

            Console.Write("Favorite Number: ");
            Console.ForegroundColor = (int.Parse(favoriteNumber) > 10)?ConsoleColor.Green:ConsoleColor.White;
            Console.WriteLine(favoriteNumber);
            Console.ResetColor();

            Console.Write("Favorite Color: ");
            Console.ForegroundColor = ColorChooser(favoriteColor);
            Console.WriteLine(favoriteColor);
            Console.ResetColor();
            Console.WriteLine();




            string GetFirstName()
            {
                Console.WriteLine("Hello! What is your first name?");
                return Console.ReadLine();
            }
            string GetLastName()
            {
                Console.WriteLine($"Hi {firstName}! What is your last name?");
                return Console.ReadLine();
            }
            string GetFavoriteNumber()
            {
                int fave = 0;
                try
                {
                    Console.WriteLine("What is your favorite number?");
                    fave = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("What you entered is not a number. Lets try that again.");
                    GetFavoriteNumber();
                }
                return $"{fave}";

            }
            string GetFavoriteAnimal()
            {
                Console.WriteLine("What is your favorite animal?");
                return Console.ReadLine();
            }
            string GetFavoriteColor()
            {
                Console.WriteLine("What is your favorite color?");
                return Console.ReadLine();
            }
        }
        
        static ConsoleColor ColorChooser(string color)
        {
            foreach (System.ConsoleColor name in Enum.GetValues(typeof(ConsoleColor)))
                {
                if (name.ToString().ToLower() == color.ToLower())
                {
                    return name;
                }
            }

            return ConsoleColor.White;
        }

    }

}
