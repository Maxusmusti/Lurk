using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTesto
{
    class ContentStream
    {
        List<ContentPiece> content;

        public ContentStream()
        {
            content = new List<ContentPiece>();
        }

        public void AddContent(List<ContentPiece> newContent)
        {
            content.AddRange(newContent);
            SortContent();
        }

        private void SortContent()
        {
            content.Sort(ContentPiece.CompareByDate);
        }

        public void Display()
        {
            foreach (ContentPiece piece in content)
            {
                piece.Display();
            }
        }
    }
}
