namespace TweetAnalysis
{
    partial class AnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TweetPage = new System.Windows.Forms.TabPage();
            this.UserPage = new System.Windows.Forms.TabPage();
            this.HashTagPage = new System.Windows.Forms.TabPage();
            this.tweetListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tweetTextBox = new System.Windows.Forms.RichTextBox();
            this.searchPage = new System.Windows.Forms.TabPage();
            this.searchQueryTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iTweetsFoundLabel = new System.Windows.Forms.Label();
            this.analysisPage = new System.Windows.Forms.TabPage();
            this.userInfo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.hashTagTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hashTagListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.wordPage = new System.Windows.Forms.TabPage();
            this.settingsApplyButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.TweetPage.SuspendLayout();
            this.UserPage.SuspendLayout();
            this.HashTagPage.SuspendLayout();
            this.searchPage.SuspendLayout();
            this.analysisPage.SuspendLayout();
            this.wordPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.searchPage);
            this.TabControl.Controls.Add(this.TweetPage);
            this.TabControl.Controls.Add(this.wordPage);
            this.TabControl.Controls.Add(this.UserPage);
            this.TabControl.Controls.Add(this.HashTagPage);
            this.TabControl.Controls.Add(this.analysisPage);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(580, 442);
            this.TabControl.TabIndex = 0;
            // 
            // TweetPage
            // 
            this.TweetPage.Controls.Add(this.tweetTextBox);
            this.TweetPage.Controls.Add(this.label1);
            this.TweetPage.Controls.Add(this.tweetListBox);
            this.TweetPage.Location = new System.Drawing.Point(4, 22);
            this.TweetPage.Name = "TweetPage";
            this.TweetPage.Padding = new System.Windows.Forms.Padding(3);
            this.TweetPage.Size = new System.Drawing.Size(572, 416);
            this.TweetPage.TabIndex = 0;
            this.TweetPage.Text = "Tweets";
            this.TweetPage.UseVisualStyleBackColor = true;
            // 
            // UserPage
            // 
            this.UserPage.Controls.Add(this.userInfo);
            this.UserPage.Controls.Add(this.label5);
            this.UserPage.Controls.Add(this.userListBox);
            this.UserPage.Location = new System.Drawing.Point(4, 22);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(572, 416);
            this.UserPage.TabIndex = 1;
            this.UserPage.Text = "Users";
            this.UserPage.UseVisualStyleBackColor = true;
            // 
            // HashTagPage
            // 
            this.HashTagPage.Controls.Add(this.hashTagTextBox);
            this.HashTagPage.Controls.Add(this.label6);
            this.HashTagPage.Controls.Add(this.hashTagListBox);
            this.HashTagPage.Location = new System.Drawing.Point(4, 22);
            this.HashTagPage.Name = "HashTagPage";
            this.HashTagPage.Padding = new System.Windows.Forms.Padding(3);
            this.HashTagPage.Size = new System.Drawing.Size(572, 416);
            this.HashTagPage.TabIndex = 2;
            this.HashTagPage.Text = "Hash Tags";
            this.HashTagPage.UseVisualStyleBackColor = true;
            // 
            // tweetListBox
            // 
            this.tweetListBox.FormattingEnabled = true;
            this.tweetListBox.Location = new System.Drawing.Point(6, 23);
            this.tweetListBox.Name = "tweetListBox";
            this.tweetListBox.Size = new System.Drawing.Size(559, 238);
            this.tweetListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tweets";
            // 
            // tweetTextBox
            // 
            this.tweetTextBox.Location = new System.Drawing.Point(6, 275);
            this.tweetTextBox.Name = "tweetTextBox";
            this.tweetTextBox.Size = new System.Drawing.Size(559, 135);
            this.tweetTextBox.TabIndex = 2;
            this.tweetTextBox.Text = "";
            // 
            // searchPage
            // 
            this.searchPage.Controls.Add(this.label30);
            this.searchPage.Controls.Add(this.textBox3);
            this.searchPage.Controls.Add(this.label29);
            this.searchPage.Controls.Add(this.textBox2);
            this.searchPage.Controls.Add(this.label21);
            this.searchPage.Controls.Add(this.settingsApplyButton);
            this.searchPage.Controls.Add(this.textBox1);
            this.searchPage.Controls.Add(this.label11);
            this.searchPage.Controls.Add(this.iTweetsFoundLabel);
            this.searchPage.Controls.Add(this.label4);
            this.searchPage.Controls.Add(this.label3);
            this.searchPage.Controls.Add(this.label2);
            this.searchPage.Controls.Add(this.searchButton);
            this.searchPage.Controls.Add(this.searchQueryTextBox);
            this.searchPage.Location = new System.Drawing.Point(4, 22);
            this.searchPage.Name = "searchPage";
            this.searchPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchPage.Size = new System.Drawing.Size(572, 416);
            this.searchPage.TabIndex = 3;
            this.searchPage.Text = "Search";
            this.searchPage.UseVisualStyleBackColor = true;
            // 
            // searchQueryTextBox
            // 
            this.searchQueryTextBox.Location = new System.Drawing.Point(6, 39);
            this.searchQueryTextBox.Name = "searchQueryTextBox";
            this.searchQueryTextBox.Size = new System.Drawing.Size(478, 20);
            this.searchQueryTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(491, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Query";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Results:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tweets found:";
            // 
            // iTweetsFoundLabel
            // 
            this.iTweetsFoundLabel.AutoSize = true;
            this.iTweetsFoundLabel.Location = new System.Drawing.Point(87, 83);
            this.iTweetsFoundLabel.Name = "iTweetsFoundLabel";
            this.iTweetsFoundLabel.Size = new System.Drawing.Size(13, 13);
            this.iTweetsFoundLabel.TabIndex = 5;
            this.iTweetsFoundLabel.Text = "0";
            // 
            // analysisPage
            // 
            this.analysisPage.Controls.Add(this.label17);
            this.analysisPage.Controls.Add(this.label18);
            this.analysisPage.Controls.Add(this.label19);
            this.analysisPage.Controls.Add(this.label27);
            this.analysisPage.Controls.Add(this.label26);
            this.analysisPage.Controls.Add(this.label25);
            this.analysisPage.Controls.Add(this.label22);
            this.analysisPage.Controls.Add(this.label23);
            this.analysisPage.Controls.Add(this.label24);
            this.analysisPage.Controls.Add(this.label20);
            this.analysisPage.Controls.Add(this.label16);
            this.analysisPage.Controls.Add(this.label15);
            this.analysisPage.Controls.Add(this.label14);
            this.analysisPage.Controls.Add(this.label13);
            this.analysisPage.Controls.Add(this.label12);
            this.analysisPage.Controls.Add(this.label10);
            this.analysisPage.Controls.Add(this.label9);
            this.analysisPage.Controls.Add(this.label8);
            this.analysisPage.Controls.Add(this.label7);
            this.analysisPage.Location = new System.Drawing.Point(4, 22);
            this.analysisPage.Name = "analysisPage";
            this.analysisPage.Size = new System.Drawing.Size(572, 416);
            this.analysisPage.TabIndex = 4;
            this.analysisPage.Text = "Analysis Results";
            this.analysisPage.UseVisualStyleBackColor = true;
            // 
            // userInfo
            // 
            this.userInfo.Location = new System.Drawing.Point(6, 275);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(559, 135);
            this.userInfo.TabIndex = 5;
            this.userInfo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Users";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(6, 23);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(559, 238);
            this.userListBox.TabIndex = 3;
            // 
            // hashTagTextBox
            // 
            this.hashTagTextBox.Location = new System.Drawing.Point(6, 275);
            this.hashTagTextBox.Name = "hashTagTextBox";
            this.hashTagTextBox.Size = new System.Drawing.Size(559, 135);
            this.hashTagTextBox.TabIndex = 8;
            this.hashTagTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hash Tags";
            // 
            // hashTagListBox
            // 
            this.hashTagListBox.FormattingEnabled = true;
            this.hashTagListBox.Location = new System.Drawing.Point(6, 23);
            this.hashTagListBox.Name = "hashTagListBox";
            this.hashTagListBox.Size = new System.Drawing.Size(559, 238);
            this.hashTagListBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Word Analysis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Least Common Word:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Most Common Word:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Least Common Word Count:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Analysis Settings";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "User Analysis";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Most Common User:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "User Tweets:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "User Follower Count:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Hashtag Analysis";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Most Common Word Count:";
            // 
            // wordPage
            // 
            this.wordPage.Controls.Add(this.richTextBox1);
            this.wordPage.Controls.Add(this.label28);
            this.wordPage.Controls.Add(this.listBox1);
            this.wordPage.Location = new System.Drawing.Point(4, 22);
            this.wordPage.Name = "wordPage";
            this.wordPage.Size = new System.Drawing.Size(572, 416);
            this.wordPage.TabIndex = 5;
            this.wordPage.Text = "Words";
            this.wordPage.UseVisualStyleBackColor = true;
            // 
            // settingsApplyButton
            // 
            this.settingsApplyButton.Location = new System.Drawing.Point(491, 387);
            this.settingsApplyButton.Name = "settingsApplyButton";
            this.settingsApplyButton.Size = new System.Drawing.Size(75, 23);
            this.settingsApplyButton.TabIndex = 8;
            this.settingsApplyButton.Text = "Apply";
            this.settingsApplyButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 188);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(309, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Words to omit in most common and least common word analysis:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 226);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "User Follower Count:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 213);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "User Tweets:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 200);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(105, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Least Common User:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 177);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "User Mentions:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 239);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 13);
            this.label26.TabIndex = 17;
            this.label26.Text = "User Mentions:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Most Common Hash Tag Count:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 314);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Least Common Hash Tag Count:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 327);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Most Common Hash Tag:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 301);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(130, 13);
            this.label27.TabIndex = 18;
            this.label27.Text = "Least Common Hash Tag:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 275);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(559, 135);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 7);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "Tweets";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(559, 238);
            this.listBox1.TabIndex = 3;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 241);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(338, 13);
            this.label29.TabIndex = 11;
            this.label29.Text = "Hashtags to omit in most common and least common hashtag analysis:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(478, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 296);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(302, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "Users to omit in most common and least common user analysis:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 312);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(478, 20);
            this.textBox3.TabIndex = 12;
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 466);
            this.Controls.Add(this.TabControl);
            this.Name = "AnalysisForm";
            this.Text = "Tweet Analysis";
            this.TabControl.ResumeLayout(false);
            this.TweetPage.ResumeLayout(false);
            this.TweetPage.PerformLayout();
            this.UserPage.ResumeLayout(false);
            this.UserPage.PerformLayout();
            this.HashTagPage.ResumeLayout(false);
            this.HashTagPage.PerformLayout();
            this.searchPage.ResumeLayout(false);
            this.searchPage.PerformLayout();
            this.analysisPage.ResumeLayout(false);
            this.analysisPage.PerformLayout();
            this.wordPage.ResumeLayout(false);
            this.wordPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TweetPage;
        private System.Windows.Forms.ListBox tweetListBox;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.TabPage HashTagPage;
        private System.Windows.Forms.RichTextBox tweetTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage searchPage;
        private System.Windows.Forms.Label iTweetsFoundLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchQueryTextBox;
        private System.Windows.Forms.RichTextBox userInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.TabPage analysisPage;
        private System.Windows.Forms.RichTextBox hashTagTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox hashTagListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button settingsApplyButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage wordPage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox2;
    }
}

