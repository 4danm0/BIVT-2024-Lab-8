using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_8
{
    public class Purple_2 : Purple
    {
        private string[] _output;
        public string[] Output
        {
            get
            {
                if (_output == null)
                    return null;

                string[] copy = new string[_output.Length];
                Array.Copy(_output, copy, _output.Length);
                return copy;
            }
        }
        public Purple_2(string input) : base(input) { }

        public override void Review()
        {
            if (Input == null) return;

            string[] words = Input.Split(' ');
            if (words.Length == 0) return;

            string[] lines = new string[0];
            string[] currentLineWords = new string[0];
            int currentLength = -1;

            for (int i = 0; i < words.Length; i++)
            {
                if (currentLength + 1 + words[i].Length <= 50)
                {
                    Array.Resize(ref currentLineWords, currentLineWords.Length + 1);
                    currentLineWords[currentLineWords.Length - 1] = words[i];
                    currentLength += 1 + words[i].Length;
                }
                else
                {
                    string formattedLine = FormatLine(currentLineWords, currentLength);
                    Array.Resize(ref lines, lines.Length + 1);
                    lines[lines.Length - 1] = formattedLine;

                    Array.Resize(ref currentLineWords, 1);
                    currentLineWords[0] = words[i];
                    currentLength = words[i].Length;
                }
            }

            if (currentLineWords.Length > 0)
            {
                string formattedLine = FormatLine(currentLineWords, currentLength);
                Array.Resize(ref lines, lines.Length + 1);
                lines[lines.Length - 1] = formattedLine;
            }

            _output = lines;
        }

        private string FormatLine(string[] words, int currentLength)
        {
            if (words.Length == 1)
                return words[0];

            int totalSpacesToAdd = 50 - currentLength;
            int baseSpaces = 1 + totalSpacesToAdd / (words.Length - 1);
            int extraSpaces = totalSpacesToAdd % (words.Length - 1);

            StringBuilder sb = new StringBuilder(words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                sb.Append(' ');
                if (i <= extraSpaces) sb.Append(' ');
                sb.Append(' ', baseSpaces - 1);
                sb.Append(words[i]);
            }

            return sb.ToString();
        }


        public override string ToString()
        {
            if (_output == null) return null;

            return string.Join(Environment.NewLine, _output);
        }
    }
}
