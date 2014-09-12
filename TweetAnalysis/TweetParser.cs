using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalysis
{
    class TweetParser
    {
        public Tweet[] Tweets { get; set; }
        public Word[] Words { get; set; }
        public Hashtag[] Hashtags { get; set; }
        public User[] Users { get; set; }

        public void ParseTweet(string text);
        public int OccurrencesOfKeyword(string keyword);
        public int GetTweetCountOfUser(string user);
        public int OccurrencesOfHashtag(string hashtag);
    }
}
