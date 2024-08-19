using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    public interface IFileAnalyzer
    {
        void Analyze(FileInfo fileInfo);
    }
}
