package com.example.twitterreddit;

import java.util.ArrayList;
import java.util.List;

class Subreddit implements ContentSource
        {
private String name;

public Subreddit(String name)
        {
        this.name = name;
        }

public List<ContentPiece> ProduceContent()
        {
        List<ContentPiece> hotPosts = new ArrayList<ContentPiece>();

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
