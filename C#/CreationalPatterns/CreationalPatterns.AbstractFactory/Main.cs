using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IDocumentConverter converter1 = new PdfConverter();
            //IDocumentConverter converter2 = new DocxConverter();
            //IDocumentConverter converter3 = new CsvConverter();

            //converter1.ConvertFile();
            //converter2.ConvertFile();
            //converter3.ConvertFile();
            //Console.ReadLine();

            IDocumentConverterFactory documentConverterFactory = CreateConverterFactoryByFormat("pdf");
            IDocumentConverter converter = documentConverterFactory.CreateConverter();
            converter.ConvertFile();
            Console.ReadLine();

        }

        public static IDocumentConverterFactory CreateConverterFactoryByFormat(string format)
        {
            if(format.Equals("csv", StringComparison.InvariantCultureIgnoreCase))
            {
                return new CsvConverterFactory();
            }
            else if(format.Equals("pdf", StringComparison.InvariantCultureIgnoreCase))
            {
                return new PdfConverterFactory();
            }
            else if (format.Equals("docx", StringComparison.InvariantCultureIgnoreCase))
            {
                return new DocxConverterFactory();
            }
            else
            {
                throw new SystemException("Wrong format: " + format);
            }
        }
    }
}
