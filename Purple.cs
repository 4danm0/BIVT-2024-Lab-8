using System;
using System.Linq;


namespace Lab_8
{
    public abstract class Purple
    {
        private string _input;
        public string Input => _input;


        static protected readonly char[] _enders = { '.', '!', '?' };
        static protected readonly char[] _signs = { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
        static protected readonly char[] _numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static protected readonly char[] _allsigns = { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}',
                                                            '/',' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public Purple(string input)
        {
            _input = input;
        }
       
        public abstract void Review();
    }
}
