using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalysis
{
    class TextEntity
    {
        public string Name { get; set; }
        public int Occurrences { get; set; }

        public TextEntity()
        {
            Name = "";
            Occurrences = 0;
        }
    }
}
