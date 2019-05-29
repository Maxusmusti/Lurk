using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Lurk
{
    class Subreddit : ContentSource
    {
        private string name;

        public Subreddit(string name)
        {
            this.name = name;
        }

        public override List<ContentPiece> ProduceContent()
        {
            List<ContentPiece> hotPosts = new List<ContentPiece>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.reddit.com/r/" + name + "/hot.json");
            string html;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            //Console.WriteLine(html);

            dynamic listing = JsonConvert.DeserializeObject(html);
            for(int i = 0; i < (int)listing["data"]["dist"]; i++)
            {
                hotPosts.Add(new RedditPost(listing["data"]["children"][i]));
            }
            return hotPosts;
        }
    }
}
