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

        /// <summary>
        /// A class that manages the parsing process of tweets, can store the results of multiple tweet parses.
        /// </summary>
        public TweetParser()
        {
            Tweets = new List<Tweet>();
            Words = new List<Word>();
            Hashtags = new List<Hashtag>();
            Users = new List<User>();
        }

        /// <summary>
        /// Parse a single string to store in various data structures.
        /// </summary>
        /// <param name="text">The text to be parsed.</param>
        public void ParseTweet(string text)
        {
            Tweet tweet = new Tweet();
            tweet.Text = text;
            Tweets.Add(tweet);

            _addToCollection(Users, ref text, "@");
            _addToCollection(Hashtags, ref text, "#");
            _addToCollection(Words, ref text, "");
        }

        /// <summary>
        /// Clear the stored tweet information.
        /// </summary>
        public void Clear()
        {
            Tweets.Clear();
            Words.Clear();
            Hashtags.Clear();
            Users.Clear();
        }

        /// <summary>
        /// Search for and add individual entities to a given data structure.
        /// </summary>
        /// <param name="entities">The list to add the various entities to.</param>
        /// <param name="text">The text to parse.</param>
        /// <param name="prefixToText">The prefix to search for.</param>
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

        /// <summary>
        /// Get the occurrences of a given keyword.
        /// </summary>
        /// <param name="keyword">The word to find.</param>
        /// <returns>The number of occurrences of <c>keyword</c>.</returns>
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

        /// <summary>
        /// Get the occurrences of a given user.
        /// </summary>
        /// <param name="userName">The username to find.</param>
        /// <returns>The number of occurrences of <c>userName</c>.</returns>
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

        /// <summary>
        /// Get the occurrences of a given hashtag.
        /// </summary>
        /// <param name="userName">The hashtag to find.</param>
        /// <returns>The number of occurrences of <c>hashtag</c>.</returns>
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
