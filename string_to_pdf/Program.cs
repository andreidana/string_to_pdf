namespace string_to_pdf
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "test.pdf";
            var text = "the quick brown fox jumps over the lazy dog";
            var printer = new Printer(fileName, text);
            printer.PDF();
        }
    }
}
