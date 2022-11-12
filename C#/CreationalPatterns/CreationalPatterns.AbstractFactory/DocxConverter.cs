using System;

namespace CreationalPatterns.AbstractFactory
{
    public class DocxConverter : IDocumentConverter
    {
        public void ConvertFile()
        {
            Console.WriteLine("Converting to docx...");
        }
    }
    
}
