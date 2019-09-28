package com.example.twitterreddit;

import java.time.LocalDateTime;

abstract class ContentPiece implements Comparable<ContentPiece>
{
    public LocalDateTime timeStamp;

    public abstract void Display();

    public static int compareTo(ContentPiece piece1, ContentPiece piece2)
    {
        return piece1.timeStamp.compareTo(piece2.timeStamp);
    }
}