class TextFileWriter
{
    static void Main(string[] args)
    {
        // создать запись и открыть файл
        TextWriter tw = new StreamWriter("startup.txt");

        // написать строку текста в файл
        tw.WriteLine(DateTime.Now);

        // закрыть поток
        tw.Close();
    }
}