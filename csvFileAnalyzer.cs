using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    internal class csvFileAnalyzer : FileAnalyzer, IFileAnalyzer
    {
        public void Analyze(FileInfo fileInfo)
        {
            Results results = new Results();
            string [] FileString = File.ReadAllLines(fileInfo.FullName);
            var fields = FileString[0].Split(',');
            SetResultes(results);
        }
    }
}
