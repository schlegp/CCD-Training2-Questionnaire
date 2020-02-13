using QuestionnaireClientSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireClientSide
{
    public class QuestionHandler
    {
        public Interpreter interpreter;
        public FileHandler fileHandler;
        public QuestionHandler()
        {
            interpreter = new Interpreter();
            fileHandler = new FileHandler();
        }

        public async Task<IEnumerable<Question>> Provide()
        {
            var lines = await fileHandler.ReadFile("questionnaire.txt");
            var Questions = interpreter.Interpret(lines);
            return Questions;
        }

    }
}
