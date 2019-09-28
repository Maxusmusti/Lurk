package com.example.twitterreddit;

import java.time.LocalDateTime;

class RedditPost extends ContentPiece {
    private String title;
    private String selfText;
    private String subreddit;

    public RedditPost(dynamic jsonData) {
            title = jsonData["data"]["title"];
            selfText = jsonData["data"]["selftext"];
            subreddit = ((string)jsonData["data"]["subreddit_name_prefixed"]).Substring(2);
            timeStamp = new LocalDateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            timeStamp = timeStamp.AddSeconds((int)jsonData["data"]["created"]);
    }
    public void Display() {
            System.out.print("[" + timeStamp.toString() + "]: Reddit post on /r/" + subreddit + ": " + title);
            //Console.WriteLine(selfText)
    }

    public int comapreTo(RedditPost one, RedditPost two){
        return 0;
    }