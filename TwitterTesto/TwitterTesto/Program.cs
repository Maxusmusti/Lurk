using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterTesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Subreddit showerThoughts = new Subreddit("showerthoughts");
            ContentStream cs = new ContentStream();

            //cs.AddContent(showerThoughts.ProduceContent());

            cs.Display();
            Console.Read();

            Tweet testTweet = new Tweet();
            testTweet.printHits();
            Console.Read();
        }
    }
}
