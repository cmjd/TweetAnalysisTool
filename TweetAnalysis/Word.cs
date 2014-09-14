using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalysis
{
    class Word : TextEntity
    {
        public override string ToString()
        {
            return "Word: " + Text + " | Occurrences: " + Occurrences;
        }
    }
}
