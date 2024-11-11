using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsThirdLab.src.Algorithms
{
    internal class Token
    {

    }

    internal class Number : Token
    {
        public double Symbol;

        public Number(double num)
        {
            Symbol = num;
        }
    }

    internal class Brackets : Token
    {
        public char Symbol;
        public bool IsClosing;

        public Brackets(char symbol)
        {
            if (symbol != '(' && symbol != ')')
                throw new ArgumentException("This is not valid bracket");

            IsClosing = symbol == ')';
            Symbol = symbol;
        }
    }
}
