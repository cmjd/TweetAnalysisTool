using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TweetAnalysis
{
    class TweetParser
    {
        public List<Tweet> Tweets { get; set; }
        public List<Word> Words { get; set; }
        public List<Hashtag> Hashtags { get; set; }
        public List<User> Users { get; set; }

        public TweetParser()
        {
            Tweets = new List<Tweet>();
            Words = new List<Word>();
            Hashtags = new List<Hashtag>();
            Users = new List<User>();
        }

        public void ParseTweet(string text)
        {
            Tweet tweet = new Tweet();
            tweet.Text = text;
            Tweets.Add(tweet);

            _addToCollection(Users, ref text, "@");
            _addToCollection(Hashtags, ref text, "#");
            _addToCollection(Words, ref text, "");
        }

        private void _addToCollection(IEnumerable<TextEntity> entities, ref string text, string prefixToText)
        {
            Regex regex = new Regex(prefixToText + @"\w+");
            MatchCollection matches = regex.Matches(text);
            int matchIndexChange = 0;
            foreach(Match match in matches)
            {
                text = text.Remove(match.Index - matchIndexChange, match.Length);
                matchIndexChange += match.Length;
                TextEntity entityToAdd;
                if(prefixToText == "@")
                {
                    entityToAdd = new User();
                }
                else if(prefixToText == "#")
                {
                    entityToAdd = new Hashtag();
                }
                else
                {
                    entityToAdd = new Word();
                }
                entityToAdd.Text = match.Value;
                entityToAdd.Text = entityToAdd.Text.Remove(0, prefixToText.Length);

                bool found = false;
                foreach (TextEntity entity in entities)
                {
                    if (entity.CompareText(entityToAdd.Text))
                    {
                        entity.Occurrences++;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    if (prefixToText == "@")
                    {
                        Users.Add((User)entityToAdd);
                    }
                    else if(prefixToText == "#")
                    {
                        Hashtags.Add((Hashtag)entityToAdd);
                    }
                    else
                    {
                        Words.Add((Word)entityToAdd);
                    }
                }
            }
        }

        public int OccurrencesOfKeyword(string keyword)
        {
            foreach(Word word in Words)
            {
                if(word.CompareText(keyword))
                {
                    return word.Occurrences;
                }
            }
            return 0;
        }

        public int GetTweetCountOfUser(string userName)
        {
            foreach (User user in Users)
            {
                if (user.CompareText(userName))
                {
                    return user.Occurrences;
                }
            }
            return 0;
        }

        public int OccurrencesOfHashtag(string hashtag)
        {
            foreach (Hashtag tag in Hashtags)
            {
                if (tag.CompareText(hashtag))
                {
                    return tag.Occurrences;
                }
            }
            return 0;
        }
    }
}
