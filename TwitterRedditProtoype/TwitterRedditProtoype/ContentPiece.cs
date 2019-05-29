using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lurk
{
    abstract class ContentPiece
    {
        protected DateTime timeStamp;

        public abstract void Display();

        public static int CompareByDate(ContentPiece piece1, ContentPiece piece2)
        {
            return piece1.timeStamp.CompareTo(piece2.timeStamp);
        }
    }
}
