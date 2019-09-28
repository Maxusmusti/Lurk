using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterTesto
{
    class Program
    {
        static Tweet testTweet;

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("Point 0");

            Subreddit showerThoughts = new Subreddit("showerthoughts");
            ContentStream cs = new ContentStream();
            //cs.AddContent(showerThoughts.ProduceContent());

            cs.Display();
            Console.Read();
            Console.WriteLine("Point 1");
            testTweet = new Tweet();
            testTweet.printHits();
            Console.WriteLine("Point 2");
            Form1.setLabel(testTweet.getOutput());
            Console.WriteLine(testTweet.getOutput());
            Console.WriteLine("Point 3");
            Console.Read();

            Application.Run(new Form1());

            
           


        }

        public static void refresh()
        {
            testTweet.printHits();
            Form1.setLabel(testTweet.getOutput());
        }
    }
}
