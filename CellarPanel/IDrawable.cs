using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellarPanel
{
   public interface IDrawable
    {
        void MakePointA(Point vrpA);
        void MakePointB(Point vrpB);
        void Draw(Graphics vrpContext);
    }
}
