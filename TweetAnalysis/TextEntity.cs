using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalysis
{
    class TextEntity : IComparable<TextEntity>
    {
        public string Text { get; set; }
        public int Occurrences { get; set; }

        public TextEntity()
        {
            Text = "";
            Occurrences = 1;
        }

        public bool CompareText(string textToCompare)
        {
            return Text == textToCompare;
        }

        int IComparable<TextEntity>.CompareTo (TextEntity other)
        {
            if(Occurrences < other.Occurrences)
            {
                return -1;
            }
            else if(Occurrences == other.Occurrences)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
