package com.example.twitterreddit;

import java.util.ArrayList;
import java.util.List;

class User
{
    List<Category> categories;
    List<Subreddit> subreddits;

    public User(){
        categories = new ArrayList<Category>();
        subreddits = new ArrayList<Subreddit>();
    }
    public User(List<Category> categories, List<Subreddit> subreddits){
        this.categories = categories;
        this.subreddits = subreddits;
    }
    public void AddCategory(Category c){
        categories.add(c);
    }
    public void AddSubreddit(Subreddit s){
        subreddits.add(s);
    }
    public void RemoveCategory(Category c){
        if(c != null){
            if(categories.contains(c))
                categories.remove(c);
        }
    }
    public void RemoveSubreddit(Subreddit s){
        if(s != null){
            if(subreddits.contains(s))
                subreddits.remove(s);
        }
    }
    public void Feed(){
        for(Category c : categories){
            for(ContentPiece piece : c.GetContentPieces())
            {
                piece.Display();
            }
        }
        for(Subreddit s : subreddits){
            for(ContentPiece piece : s.ProduceContent())
            {
                piece.Display();
            }
        }
    }
}