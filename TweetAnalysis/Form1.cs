using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TweetAnalysis
{
    public partial class AnalysisForm : Form
    {
        public AnalysisForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            tweetListBox.Items.Clear();
            wordListBox.Items.Clear();
            hashtagListBox.Items.Clear();
            userListBox.Items.Clear();

            TweetParser parser = new TweetParser();
            parser.ParseTweet(searchQueryTextBox.Text);

            tweetListBox.Items.AddRange(parser.Tweets.ToArray());
            wordListBox.Items.AddRange(parser.Words.ToArray());
            hashtagListBox.Items.AddRange(parser.Hashtags.ToArray());
            userListBox.Items.AddRange(parser.Users.ToArray());
        }
    }
}
