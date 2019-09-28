package com.example.twitterreddit;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

class ContentStream
{
    List<ContentPiece> content;

    public ContentStream()
    {
        content = new ArrayList<ContentPiece>();
    }

    public void AddContent(List<ContentPiece> newContent)
    {
        content.addAll(newContent);
        SortContent();
    }

    private void SortContent()
    {
        Collections.sort(content);
    }

    public void Display()
    {
        for(ContentPiece piece : content)
        {
            piece.Display();
        }
    }
}