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
        public AnalysisForm()
        {
            InitializeComponent();
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

            TweetParser parser = new TweetParser();
            foreach(JToken textToken in tokens)
            {
                parser.ParseTweet(textToken["text"].ToString());
            }
            
            tweetListBox.Items.AddRange(parser.Tweets.ToArray());
            wordListBox.Items.AddRange(parser.Words.ToArray());
            hashtagListBox.Items.AddRange(parser.Hashtags.ToArray());
            userListBox.Items.AddRange(parser.Users.ToArray());
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
