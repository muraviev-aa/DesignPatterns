package Abstract_factory;

public class Main {

    public static void main(String[] args) {

//        DocumentConverter converter1 = new CsvConverter();
//        DocumentConverter converter2 = new DocxConverter();
//        DocumentConverter converter3 = new PdfConverter();
//
//        converter1.convertFile();
//        converter2.convertFile();
//        converter3.convertFile();

        DocumentConverterFactory documentConverterFactory = createConverterFactoryByFormat("docx");
        DocumentConverter converter = documentConverterFactory.createConverter();
        converter.convertFile();

    }

    public static DocumentConverterFactory createConverterFactoryByFormat(String format) {
        if (format.equalsIgnoreCase("csv")) {
            return new CsvConverterFactory();
        } else if (format.equalsIgnoreCase("docx")) {
            return new DocxConverterFactory();
        } else if (format.equalsIgnoreCase("pdf")) {
            return new PdfConverterFactory();
        } else {
            throw new RuntimeException("Wrong format: " + format);
        }

    }
}
