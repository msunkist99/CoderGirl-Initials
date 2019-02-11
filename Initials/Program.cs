using System;

namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name as first middle last");
            string fullName = Console.ReadLine();

            string initials = ReturnInitials(fullName);

            Console.WriteLine($"Initials are - {initials}");

            Console.ReadLine();
        }

        // TODO: Create a method that takes in a full name and return the initials in all capital letters.

        /// <summary>
        /// takes a full name - names seperated by a space - and returns upper case initials for the full name
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns>upper case initials</returns>
        private static string ReturnInitials(string fullName)
        {
            string[] names = fullName.Split(" ");
            string initials = null;

            for (int i = 0; i < names.Length; i++)
            {
                initials = initials + names[i].Substring(0, 1);
            }

            initials = initials.ToUpper();

            return initials;
        }
    }
}
