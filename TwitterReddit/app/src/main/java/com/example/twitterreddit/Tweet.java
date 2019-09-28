package com.example.twitterreddit;

import java.time.LocalDateTime;

class Tweet extends ContentPiece
        {
        String testOutput = "NOTHING";

public void printHits()
        {
        OAuthTwitterWrapper oAuthTwitterWrapper = new OAuthTwitterWrapper.OAuthTwitterWrapper();
        System.out.println("**** Time Line *****\n");
        testOutput = oAuthTwitterWrapper.GetMyTimeline();
            System.out.println(testOutput + "\n\n");

            System.out.println("**** Search *****\n");
            System.out.println(oAuthTwitterWrapper.GetSearch() + "\n\n");
        }

public String getOutput()
        {
        return testOutput;
        }


public void Display(){

        }

public static int compareTo(ContentPiece piece1, ContentPiece piece2)
        {
        return piece1.timeStamp.compareTo(piece2.timeStamp);
        }
        }
