using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lurk
{
    class RedditPost : ContentPiece
    {
        private string title;
        private string selfText;
        private string subreddit;

        public RedditPost(dynamic jsonData)
        {
            title = jsonData["data"]["title"];
            selfText = jsonData["data"]["selftext"];
            subreddit = ((string)jsonData["data"]["subreddit_name_prefixed"]).Substring(2);
            timeStamp = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            timeStamp = timeStamp.AddSeconds((int)jsonData["data"]["created"]);
        }
        public override void Display()
        {
            Console.WriteLine("[" + timeStamp.ToString() + "]: Reddit post on /r/" + subreddit + ": " + title);
            //Console.WriteLine(selfText);
        }
    }
}
