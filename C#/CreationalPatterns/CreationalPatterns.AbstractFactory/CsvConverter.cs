using System;

namespace CreationalPatterns.AbstractFactory
{
    internal class CsvConverter : IDocumentConverter
    {
        public void ConvertFile()
        {
            Console.WriteLine("Converting to csv..."); ;
        }
    }
}
