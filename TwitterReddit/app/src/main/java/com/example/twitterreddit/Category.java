package com.example.twitterreddit;

import java.util.List;

class Category
{
    private String name;
    private List<ContentPiece> contentPieces;
    public List<ContentPiece> GetContentPieces()
    {
        return contentPieces;
    }
}
