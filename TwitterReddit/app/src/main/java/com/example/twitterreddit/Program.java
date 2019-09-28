package com.example.twitterreddit;

import android.app.Application;

import java.io.Console;

class Program
{
    static Tweet testTweet;

    static void Main(String[] args)
    {
        System.out.println("Point 0");

        Subreddit showerThoughts = new Subreddit("showerthoughts");
        ContentStream cs = new ContentStream();
        //cs.AddContent(showerThoughts.ProduceContent());

        cs.Display();
        System.out.println("Point 1");
        testTweet = new Tweet();
        testTweet.printHits();
        System.out.println("Point 2");
        System.out.println(testTweet.getOutput());
        System.out.println("Point 3");





    }

    public static void refresh()
    {
        testTweet.printHits();
    }
}
