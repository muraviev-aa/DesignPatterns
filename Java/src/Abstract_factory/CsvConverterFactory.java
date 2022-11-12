package Abstract_factory;

public class CsvConverterFactory implements DocumentConverterFactory{
    @Override
    public DocumentConverter createConverter() {
        return new CsvConverter();
    }
}
