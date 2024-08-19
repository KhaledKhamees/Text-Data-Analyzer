namespace Text_Data_Analyzer_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello , this is file analyzer");
            Console.WriteLine("Enter the Directory Path");
            string DierctoryPath = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(DierctoryPath);
            if(directoryInfo.Exists == false)
            {
                Console.WriteLine("No files here , please enter the correct Path");
                return;
            }
            var fileInfo = directoryInfo.GetFiles();
            IFileAnalyzer fileAnalyzer = null;
            foreach(FileInfo file in fileInfo)
            {
                if (file.istxt())
                {
                    fileAnalyzer = new txtFileAnalyzer();
                    fileAnalyzer.Analyze(file);
                    Results results = ((FileAnalyzer)fileAnalyzer).GetResultes();
                    Console.WriteLine($"{file.Name}");
                    Console.WriteLine($"Number of wordes : {results.WourdsCount}");
                    Console.WriteLine($"Number of Lines  : {results.LinesCount}");
                    Console.WriteLine($"Number of Characters  : {results.CharCount}");
                }
                else if (file.iscsv())
                {
                    fileAnalyzer = new csvFileAnalyzer();
                    fileAnalyzer.Analyze(file);
                    Results results = ((FileAnalyzer)fileAnalyzer).GetResultes();
                    Console.WriteLine($"{file.Name}");
                    Console.WriteLine($"Number of wordes : {results.FieldsCount}");

                }
            }

        }
    }
}
