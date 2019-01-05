using System;
using System.Drawing;
using System.Drawing.Printing;

namespace string_to_pdf
{
    public class Printer
    {
        private readonly string directory;
        private readonly string file;
        private readonly string textToPrint;

        public Printer(string fileName, string text)
        {
            directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file = fileName;
            textToPrint = text;
        }

        public Printer(string fileName, string path, string text)
        {
            directory = path;
            file = fileName;
            textToPrint = text;
        }

        public void PDF()
        {
            PrintDocument pDoc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    PrinterName = "Microsoft Print to PDF",
                    PrintToFile = true,
                    PrintFileName = System.IO.Path.Combine(directory, file),
                }
            };

            pDoc.PrintPage += new PrintPageEventHandler(Print_Page);
            pDoc.Print();
        }

        public void Print_Page(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 12);
            e.Graphics.DrawString(textToPrint, font, Brushes.Black, 0, 0);
        }
    }
}
