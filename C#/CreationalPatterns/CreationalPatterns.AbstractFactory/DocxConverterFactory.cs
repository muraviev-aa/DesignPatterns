namespace CreationalPatterns.AbstractFactory
{
    internal class DocxConverterFactory : IDocumentConverterFactory
    {
        public IDocumentConverter CreateConverter()
        {
            return new DocxConverter();
        }
    }
}
