using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellarPanel
{
    public class Segments : Draw, IDrawable
    {
       private Rectangle _rect;
       private Color color;
       public string Name{set;get;}
       public bool IsSelected { set; get; }
       public List<string> ItemInSegment;

       public Color ColorProp
       {
           get
           { return color; }
           set { color = value; }
       }

       public Rectangle Rectangle {
           get { return _rect; }
       }

       public Segments(Point A, Point B, string name)
       {
           _rect = new Rectangle(A.X, A.Y, B.X - A.X, B.Y - A.Y);
           Random randomColor = new Random();
           this.Name = name;
           ItemInSegment = new List<string>();
           this.color = Color.FromArgb(100, randomColor.Next(255), randomColor.Next(255), randomColor.Next(255));
       }

       void Segments_Click(object sender, EventArgs e)
       {
          
       }

        public void MakePointA(System.Drawing.Point vrpA)
        {

          
        }

        public void MakePointB(System.Drawing.Point vrpB)
        {
           
        }

        public void Draw(System.Drawing.Graphics vrpContext)
        {
            int namevalue;
            int x;
            FontFamily fontFamily = new FontFamily("Arial");
            vrpContext.FillRectangle(new SolidBrush(ColorProp),
              Rectangle);
            namevalue = Name.Length * 4;
            x = (Rectangle.X + (Rectangle.Width) / 2) - namevalue;
            vrpContext.DrawString(this.Name,new Font(fontFamily,16,FontStyle.Regular,GraphicsUnit.Pixel),new SolidBrush(Color.Black),new PointF(x,Rectangle.Y +( Rectangle.Height)/2));
            
        }
    }
}
