using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalysis
{
    class Tweet : TextEntity
    {
        public User[] Users { get; set; }
        public Hashtag[] Hashtags { get; set; }
        public int Favourites { get; set; }
    }
}
