using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalysis
{
    class User : TextEntity
    {
        public int Followers { get; set; }
        public int Mentions { get; set; }

        public User()
        {
            Followers = 0;
            Mentions = 0;
        }

        public override string ToString()
        {
            return "Username: @" + Text + " | Occurrences: " + Occurrences + " | Followers: " + Followers + " | Mentions: " + Mentions;
        }
    }
}
