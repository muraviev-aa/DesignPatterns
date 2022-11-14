using System;
using System.Collections.Generic;

namespace CreationalPatterns.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> namesAndNums = new Dictionary<string, long>();
            namesAndNums.Add("John", 11111111111);
            namesAndNums.Add("Anna", 22222222222);
            namesAndNums.Add("Katie", 33333333333);
            namesAndNums.Add("Bob", 44444444444);


            Phonebook phonebook = new Phonebook(namesAndNums);
            Console.WriteLine(phonebook);


            PhonebookFactory phonebookFactory = new PhonebookFactory(phonebook);
            Phonebook copyPhonebook = phonebookFactory.CopyPhonebooke();
            Console.WriteLine(copyPhonebook);

            Phonebook clone = (Phonebook)phonebook.Clone();
            Console.WriteLine(clone);
            Console.ReadLine();

        }
    }
}
