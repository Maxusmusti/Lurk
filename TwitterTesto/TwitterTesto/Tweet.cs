using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace TwitterTesto
{
    class Tweet : ContentPiece
    {
        string testOutput = "NOTHING";

        public void printHits()
        {
            var oAuthTwitterWrapper = new OAuthTwitterWrapper.OAuthTwitterWrapper();
			Console.Write("**** Time Line *****\n");
            testOutput = oAuthTwitterWrapper.GetMyTimeline();
            Console.Write(testOutput + "\n\n");
  
			Console.Write("**** Search *****\n");
			Console.Write(oAuthTwitterWrapper.GetSearch() + "\n\n");
			//oAuthTwitterWrapper.TimeLineSettings = new TimeLineSettings {
            Console.ReadLine();

        }

        public string getOutput()
        {
            return testOutput;
        }

        protected DateTime timeStamp(){
            return new DateTime(); 
        }

        public override void Display(){
            
        }

        public static int CompareByDate(ContentPiece piece1, ContentPiece piece2)
        {
            return piece1.timeStamp.CompareTo(piece2.timeStamp);
        }
    }
}
