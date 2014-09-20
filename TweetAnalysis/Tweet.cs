using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalysis
{
    class Tweet : TextEntity
    {
        public List<User> Users { get; set; }
        public List<Hashtag> Hashtags { get; set; }
        public int Favourites { get; set; }

        public override string ToString()
        {
            return "Contents: " + Text + " | Retweets: " + Occurrences;
        }
    }
}
