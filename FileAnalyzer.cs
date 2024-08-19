using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    public class FileAnalyzer
    {
        private Results results; 

        public void SetResultes(Results r)
        {
            results = r;
        }
        public Results GetResultes()
        {
            return results;
        }

    }
}
