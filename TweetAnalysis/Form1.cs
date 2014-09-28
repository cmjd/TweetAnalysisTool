using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
// JSON.NET Reference http://james.newtonking.com/json/help/index.html
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TweetAnalysis
{
    public partial class AnalysisForm : Form
    {
        // Reference: https://dev.twitter.com/oauth/application-only
        const string APP_KEY = "APP KEY HERE";
        const string APP_SECRET = "APP SECRET HERE";

        string _bearerTokenCredentials;
        string _bearerToken;
        TweetParser _parser;
        public AnalysisForm()
        {
            InitializeComponent();
            _parser = new TweetParser();
        }

        private void populateAnalysisResultsPage()
        {
            Word leastCommonWord = _parser.Words.Min<Word>();
            leastCommonWordLabel.Text = leastCommonWord.Text;
            leastCommonWordCountLabel.Text = leastCommonWord.Occurrences.ToString();

            Word mostCommonWord = _parser.Words.Max<Word>();
            mostCommonWordLabel.Text = mostCommonWord.Text;
            mostCommonWordCountLabel.Text = mostCommonWord.Occurrences.ToString();

            User leastCommonUser = _parser.Users.Min<User>();
            leastCommonUserLabel.Text = leastCommonUser.Text;
            leastCommonUserTweetCountLabel.Text = leastCommonUser.Occurrences.ToString();
            leastCommonUserFollowerCountLabel.Text = leastCommonUser.Followers.ToString();
            leastCommonUserMentionCountLabel.Text = leastCommonUser.Mentions.ToString();

            User mostCommonUser = _parser.Users.Max<User>();
            mostCommonUserLabel.Text = mostCommonUser.Text;
            mostCommonUserTweetCountLabel.Text = mostCommonUser.Occurrences.ToString();
            mostCommonUserFollowerCountLabel.Text = mostCommonUser.Followers.ToString();
            mostCommonUserMentionCountLabel.Text = mostCommonUser.Mentions.ToString();

            Hashtag leastCommonHashtag = _parser.Hashtags.Min<Hashtag>();
            leastCommonHashtagLabel.Text = leastCommonHashtag.Text;
            leastCommonHashtagCountLabel.Text = leastCommonHashtag.Occurrences.ToString();

            Hashtag mostCommonHashtag = _parser.Hashtags.Max<Hashtag>();
            mostCommonHashtagLabel.Text = mostCommonHashtag.Text;
            mostCommonHashtagCountLabel.Text = mostCommonHashtag.Occurrences.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            // An encoding step according to http://www.ietf.org/rfc/rfc1738.txt should take place here, but it doesn't change the value so it can be skipped for now.
            _bearerTokenCredentials = System.Convert.ToBase64String(encoding.GetBytes(APP_KEY + ":" + APP_SECRET));

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://api.twitter.com/oauth2/token");
            request.Method = "POST";
            request.UserAgent = "Simple Tweet Analysis Tool";
            request.ContentLength = 29;
            request.KeepAlive = false;
            request.Headers.Add("Authorization: Basic " + _bearerTokenCredentials);
            
            String input = "grant_type=client_credentials";
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(encoding.GetBytes(input), 0, input.Length);
            requestStream.Close();
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader sr = new StreamReader(responseStream);
            JsonReader jsonReader = new JsonTextReader(sr);
            JObject obj = JObject.Load(jsonReader);
            JToken token = obj["access_token"];
            _bearerToken = token.ToString();


            request = (HttpWebRequest)HttpWebRequest.Create("https://api.twitter.com/1.1/search/tweets.json" + "?q=" + WebUtility.UrlEncode(searchQueryTextBox.Text) + "&count=10");
            request.Method = "GET";
            request.Headers.Add("Authorization: Bearer " + _bearerToken);
            request.UserAgent = "Simple Tweet Analysis Tool";
            request.KeepAlive = false;

            response = (HttpWebResponse)request.GetResponse();
            responseStream = response.GetResponseStream();

            sr = new StreamReader(responseStream);
            jsonReader = new JsonTextReader(sr);
            obj = JObject.Load(jsonReader);
            List<JToken>tokens = obj["statuses"].Children().ToList();
            iTweetsFoundLabel.Text = tokens.Count.ToString();

            tweetListBox.Items.Clear();
            wordListBox.Items.Clear();
            hashtagListBox.Items.Clear();
            userListBox.Items.Clear();

            _parser.Clear();
            foreach(JToken textToken in tokens)
            {
                User user = new User();
                user.Text = textToken["user"]["screen_name"].ToString();
                user.Occurrences = Convert.ToInt32(textToken["user"]["statuses_count"].ToString());
                user.Followers = Convert.ToInt32(textToken["user"]["followers_count"].ToString());
                _parser.Users.Add(user);
                _parser.ParseTweet(textToken["text"].ToString());
            }
            
            tweetListBox.Items.AddRange(_parser.Tweets.ToArray());
            wordListBox.Items.AddRange(_parser.Words.ToArray());
            hashtagListBox.Items.AddRange(_parser.Hashtags.ToArray());
            userListBox.Items.AddRange(_parser.Users.ToArray());

            populateAnalysisResultsPage();
        }

        private void tweetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tweetTextBox.Text = tweetListBox.SelectedItem.ToString();
        }

        private void wordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            wordTextBox.Text = wordListBox.SelectedItem.ToString();
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userTextBox.Text = userListBox.SelectedItem.ToString();
        }

        private void hashtagListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hashtagTextBox.Text = hashtagListBox.SelectedItem.ToString();
        }
    }
}
