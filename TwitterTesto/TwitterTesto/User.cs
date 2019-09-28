using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTesto
{
    class User
    {
        List<Category> categories;
        List<Subreddit> subreddits;

        public User(){
            categories = new List<Category>();
            subreddits = new List<Subreddit>();
        }
        public User(List<Category> categories, List<Subreddit> subreddits){
            this.categories = categories;
            this.subreddits = subreddits;
        }
        public void AddCategory(Category c){
            categories.Add(c);
        }
        public void AddSubreddit(Subreddit s){
            subreddits.Add(s);
        }
        public void RemoveCategory(Category c){
            if(c != null){
                if(categories.Contains(c))
                    categories.Remove(c);
            }
        }
        public void RemoveSubreddit(Subreddit s){
            if(s != null){
                if(subreddits.Contains(s))
                    subreddits.Remove(s);
            }
        }
        public void Feed(){
            foreach(Category c in categories){
                foreach(ContentPiece piece in c.GetContentPieces())
                {
                    piece.Display();
                }
            }
            foreach(Subreddit s in subreddits){
                foreach(ContentPiece piece in s.ProduceContent())
                {
                    piece.Display();
                }
            }
        }
    }
}
