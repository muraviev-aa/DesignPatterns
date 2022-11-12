using System;

namespace CreationalPatterns.AbstractFactory
{
    internal class PdfConverter : IDocumentConverter
    {
        public void ConvertFile()
        {
            Console.WriteLine("Converting to pdf..."); ;
        }
    }
}
