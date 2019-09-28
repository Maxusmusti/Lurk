using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTesto
{
    abstract class ContentSource
    {
        public abstract List<ContentPiece> ProduceContent();
    }
}
