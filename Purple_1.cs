
using System;
using System.Linq;
using System.Text;

namespace Lab_8
{
    public class Purple_1 : Purple
    {
        private string _output;
        public string Output => _output;

        public Purple_1(string input) : base(input) { }

        private string Reverse(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            int start = 0;
            while (start < s.Length && _signs.Contains(s[start]))
                start++;

            int end = s.Length - 1;
            while (end >= 0 && _signs.Contains(s[end]))
                end--;

            if (start > end) return s;

            string prefix = s.Substring(0, start);
            string suffix = s.Substring(end + 1);
            string word = s.Substring(start, end - start + 1);

            string reversedWord = new string(word.Reverse().ToArray());

            return prefix + reversedWord + suffix;
        }

        public override void Review()
        {
            if (string.IsNullOrEmpty(Input))
            {
                _output = Input;
                return;
            }

            string[] strSplit = Input.Split(' ');

            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i].Any(c => _numbers.Contains(c)))
                    continue;

                strSplit[i] = Reverse(strSplit[i]);
            }

            _output = string.Join(" ", strSplit);
        }

        public override string ToString()
        {
            return _output ?? string.Empty;
        }
    }
}