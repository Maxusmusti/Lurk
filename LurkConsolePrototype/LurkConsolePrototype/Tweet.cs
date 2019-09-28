using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Lurk
{
    class Tweet : ContentPiece
    {
        public void printHits()
        {
            var oAuthTwitterWrapper = new OAuthTwitterWrapper.OAuthTwitterWrapper();
			Console.Write("**** Time Line *****\n");
			Console.Write(oAuthTwitterWrapper.GetMyTimeline() + "\n\n");
			Console.Write("**** Search *****\n");
			Console.Write(oAuthTwitterWrapper.GetSearch() + "\n\n");
			//oAuthTwitterWrapper.TimeLineSettings = new TimeLineSettings {
            Console.ReadLine();

        }
        protected DateTime timeStamp(){
            return null; 
        }

        public abstract void Display(){
            
        }

        public static int CompareByDate(ContentPiece piece1, ContentPiece piece2)
        {
            return piece1.timeStamp.CompareTo(piece2.timeStamp);
        }
    }
}
