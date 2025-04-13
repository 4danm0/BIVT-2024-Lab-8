using System;
using System.Linq;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        private (string, char)[] _codes;

        public (string, char)[] Codes => _codes;

        public Purple_4(string input, (string, char)[] codes) : base(input)
        {
            _codes = codes;
        }
        public override void Review()
        {
            if (_input == null || _codes == null) return;
            string result = _input;
            foreach (var code in _codes) 
            {
                result = result.Replace(code.Item2.ToString(), code.Item1);
            }
            _output = result;

        }

        public override string ToString() => _output;
    }
}
