using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuestionnaireClientSide
{
    public class FileHandler
    {
        public async Task<IEnumerable<string>> ReadFile(string path)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44302/");
            var line = await client.GetStringAsync("/sample-data/questionnaire.txt");
            var lines = line.Split("\r\n");
            return lines;
        }
    }
}
