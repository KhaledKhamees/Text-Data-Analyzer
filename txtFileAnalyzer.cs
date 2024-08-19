using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    internal class txtFileAnalyzer : FileAnalyzer, IFileAnalyzer
    {
        public void Analyze(FileInfo fileInfo)
        {
            Results results = new Results();
            string FileString = File.ReadAllText(fileInfo.FullName);
            var words= FileString.Split(new char[] { ' ', '\n', '\r' });
            results.WourdsCount = words.Length;
            var lines = FileString.Split(new char[] { '\n', '\r' });
            results.LinesCount = lines.Length;
            results.CharCount = FileString.Length;




            SetResultes(results);
        }
    }
}
