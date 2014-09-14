using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalysis
{
    class Hashtag : TextEntity
    {
        public override string ToString()
        {
            return "Hashtag: #" + Text + " | Occurrences: " + Occurrences;
        }
    }
}
