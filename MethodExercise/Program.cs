using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a random last name: ");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("Enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.WriteLine("Enter am or pm: ");
            string amOrPm = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            string adjective = Console.ReadLine();

            Console.WriteLine("Enter a present tense verb ending in ing: ");
            string ingVerb = Console.ReadLine();

            Console.WriteLine("Enter a body part: ");
            string bodyPart = Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            string number1  = Console.ReadLine();

            Console.WriteLine("Enter another noun: ");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Enter a verb in base form: ");
            string baseVerb = Console.ReadLine();

            Console.WriteLine("Enter a liquid: ");
            string liquid = Console.ReadLine();

            Console.WriteLine("Enter another number: ");
            string number2 = Console.ReadLine();

            Console.WriteLine("Enter another time of day: ");
            string timeOfDay2 = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            string pluralNoun1 = Console.ReadLine();

            Console.WriteLine("Enter the name of an animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter another plural noun:");
            string pluralNoun2 = Console.ReadLine();

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Dear Dr. {lastName},");

            Console.WriteLine("");

            Console.WriteLine($"I cannot make it to {noun1} this {amOrPm}." +
                $"I am very {adjective} and cannot stop {ingVerb} my {bodyPart}." +
                $"I have a fever of {number1} degrees and the doctor ordered me " +
                $"to stay in {noun2} and {baseVerb} lots of {liquid}. Also, can I have a {number2} " +
                $"{timeOfDay2} extension on the essay about {pluralNoun1} ? My {animal} ate it" +
                $" and now I have to start all over");

            Console.WriteLine($"");

            Console.WriteLine($"Best {pluralNoun2},");

            Console.WriteLine($"");

            Console.WriteLine($"{name}");
        }
    }
}
