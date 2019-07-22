using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuide
{
    public class LineProcessor
    {
        public static Dictionary<string, string> SlangWordMapping = new Dictionary<string, string>();
        public void Execute(string str)
        {
            string[] splittedLine = str.Split(' ');
            SlangWordMapping.Add(splittedLine[0], splittedLine[2]);

        }
    }
}
