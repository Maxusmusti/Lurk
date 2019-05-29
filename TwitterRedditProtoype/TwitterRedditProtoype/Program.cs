using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lurk
{
    class Program
    {
        static void Main(string[] args)
        {
            Subreddit showerThoughts = new Subreddit("showerthoughts");
            ContentStream cs = new ContentStream();

            cs.AddContent(showerThoughts.ProduceContent());

            cs.Display();
            Console.Read();
        }
    }
}
