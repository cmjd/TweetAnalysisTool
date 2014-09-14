using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalysis
{
    class TextEntity
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
    }
}
