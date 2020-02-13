using Questionnaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire
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

        public IEnumerable<Question> Provide()
        {
            var lines = fileHandler.ReadFile("questionnaire.txt");
            var Questions = interpreter.Interpret(lines);
            return Questions;
        }

    }
}
