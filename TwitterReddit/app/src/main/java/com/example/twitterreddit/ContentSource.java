package com.example.twitterreddit;

import java.util.List;

interface ContentSource
{
    public abstract List<ContentPiece> ProduceContent();
}
