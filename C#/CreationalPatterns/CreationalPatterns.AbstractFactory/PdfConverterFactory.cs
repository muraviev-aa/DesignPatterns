namespace CreationalPatterns.AbstractFactory
{
    internal class PdfConverterFactory : IDocumentConverterFactory
    {
        public IDocumentConverter CreateConverter()
        {
            return new PdfConverter();
        }
    }
}
