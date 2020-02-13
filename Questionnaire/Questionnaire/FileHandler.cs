using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire
{
    public class FileHandler
    {
        public IEnumerable<string> ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
