using MyCellar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellarPanel
{
    public class CellarPanel : Panel
    {
        private Brush _DotBrush;
        private int _iDotDistance ;
        private Rectangle _DotSize;
        private int _iDotHeight;
        private bool bButtonPressed;
        private Point StartPoint;
        private Point FinishPoint;
        private Direction dDirection;
       // private Segments Segment;
        private Bitmap ClearImage;
        private List<Segments> ListSegments;
        private Segments lastHoverSegment;
        private Timer timer;
        private bool mouseDown;
        private Segments lastSegmentClick;
        private string[] names;
        private int nameIndex;
        public ISetName View { set; get; }
        private Segments newSegmentClick;

            enum Direction
        {
            Right,
            Down
        };

        public int DotHeight
        {
            get { return _iDotHeight; }
            set { _iDotHeight = value; }
        }

        public int DotDistance 
        {
            get { return _iDotDistance; } 
            set{_iDotDistance = value;} 
        }

        public CellarPanel(ISetName pView)
        {
            View = pView;
            SetStartProperty();
        }

        public CellarPanel()
        {
            SetStartProperty();       
        }
    
        private void SetStartProperty()
        {
            this._DotBrush = new SolidBrush(Color.Black);
            this.Paint += CellarPanel_Paint;
            this.MouseMove += CellarPanel_MouseMove;
            this.MouseClick += CellarPanel_MouseClick;
            this.MouseDown += CellarPanel_MouseDown;
            this.MouseUp += CellarPanel_MouseUp;
            this._iDotDistance = 10;
            this._iDotHeight = 2;
            this._DotSize.Width = _iDotHeight;
            this._DotSize.Height = _iDotHeight;
            this.ClearImage = new Bitmap(500, 500);
            this.DoubleBuffered = true;
            this.ListSegments = new List<Segments>();
            this.names = new string[15] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", };
            this.nameIndex = 0;
        }

        public void SetNewSegmentName(string pName)
        {
            if (newSegmentClick != null)
            {
                newSegmentClick.Name = pName;
                View.SegmentsList = ListSegments;
                Refresh();
            }
            
        }

        public void AdditemToSegment(string pItem,string segmentName)
        {
           Segments findSegment = ListSegments.Find(x => x.Name == segmentName);
           findSegment.ItemInSegment.Add(pItem);
           View.ItemsList = findSegment.ItemInSegment;
        }

        void CellarPanel_MouseClick(object sender, MouseEventArgs e)
        {
          newSegmentClick = CheckAllSegmentForHover(e);

            if (newSegmentClick != null)
            {
                if (lastSegmentClick != null) 
                {
                    Color tmp2 = lastSegmentClick.ColorProp;
                    lastSegmentClick.ColorProp = Color.FromArgb(100, tmp2.R, tmp2.G, tmp2.B);
                    lastSegmentClick.IsSelected = false;

                }

                Color tmp = newSegmentClick.ColorProp;
                newSegmentClick.ColorProp = Color.FromArgb(254, tmp.R, tmp.G, tmp.B);
                newSegmentClick.IsSelected = true;
                lastSegmentClick = newSegmentClick;
                View.Name = lastSegmentClick.Name;
                View.ItemsList = newSegmentClick.ItemInSegment;
                View.ActualSelectedSegment = lastSegmentClick.Name;
                Refresh();

                
            }
         
            
        }
        public void SearchSegment(string pItem)
        {
            foreach(Segments segment in ListSegments)
            {
                foreach(string item in segment.ItemInSegment)
                {
                    if (item == pItem)
                        MessageBox.Show(segment.Name);
                }
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
           
        }

        void CellarPanel_MouseUp(object sender, MouseEventArgs e)
        {        
            this.bButtonPressed = false;
            this.DrawToBitmap(this.ClearImage, this.ClientRectangle);
            decimal nearGridX = _iDotDistance * Math.Round(e.X / (decimal)_iDotDistance);
            decimal nearGridY = _iDotDistance * Math.Round(e.Y / (decimal)_iDotDistance);
            if (StartPoint.X != nearGridX && StartPoint.Y != nearGridY && CheckAllSegments(nearGridX, nearGridY))
            {
                
                Segments NewSegment = new Segments(StartPoint, FinishPoint, names[nameIndex]);
                ListSegments.Add(NewSegment);
                View.SegmentsList = ListSegments;
                View.Name = NewSegment.Name;
                nameIndex++;
            }

            this.Refresh();
        }

        

        void CellarPanel_MouseDown(object sender, MouseEventArgs e)
        {
          
                this.bButtonPressed = true;
                decimal nearGridX = _iDotDistance * Math.Round(e.X / (decimal)_iDotDistance);
                decimal nearGridY = _iDotDistance * Math.Round(e.Y / (decimal)_iDotDistance);
           
                this.StartPoint = new Point((int)nearGridX, (int)nearGridY);
                Console.WriteLine(ClearImage.GetPixel(e.X, e.Y).ToString());
              
                //this.Segment.MakePointA(this.StartPoint);
            
           
        }
        bool checkCollide(Rectangle one,Rectangle two)
        {
            // AABB 1
            int x1Min = one.X;
            int x1Max = one.X + one.Width;
            int y1Max = one.Y + one.Height;
            int y1Min = one.Y;

            // AABB 2
            int x2Min = two.X;
            int x2Max = two.X + two.Width;
            int y2Max = two.Y + two.Height;
            int y2Min = two.Y;

            // Collision tests
            if (x1Max < x2Min || x1Min > x2Max) return false;
            if (y1Max < y2Min || y1Min > y2Max) return false;

            return true;
        }
        Segments CheckAllSegmentForHover(MouseEventArgs e)
        {
            Rectangle actual = new Rectangle(e.X, e.Y, 1, 1);
            foreach (Segments item in ListSegments)
            {
                if (checkCollide(item.Rectangle, actual))
                {
                    return item;
                }

            }
            return null;
        }


        bool CheckAllSegments(decimal nearGridX,decimal nearGridY)
        {
            Rectangle actualRect = new Rectangle(StartPoint.X,StartPoint.Y,(int)nearGridX-StartPoint.X,(int)nearGridY-StartPoint.Y);
         
            foreach(Segments item in ListSegments)
            {
                if(checkCollide(item.Rectangle,actualRect))
                {
                    return false;
                }
              
            }
            return true;
        }
        void CellarPanel_MouseMove(object sender, MouseEventArgs e)
        {

            //this.Segment.MakePointB(new Point(e.X, e.Y));

            if(bButtonPressed)
            {
                decimal nearGridX = _iDotDistance * Math.Round(e.X / (decimal)_iDotDistance);
                decimal nearGridY = _iDotDistance * Math.Round(e.Y / (decimal)_iDotDistance);

                if(CheckAllSegments(nearGridX, nearGridY))
                this.FinishPoint = new Point((int)nearGridX, (int)nearGridY);

                this.Refresh();
               
                    
            }
            else
            {
                Segments hoverSegment = CheckAllSegmentForHover(e);
                if (hoverSegment != null)
                {
                    Color tmp = hoverSegment.ColorProp;
                    if(!hoverSegment.IsSelected)
                        hoverSegment.ColorProp = Color.FromArgb(150, tmp.R, tmp.G, tmp.B);
                    lastHoverSegment = hoverSegment;
                    Refresh();
                }
                else
                {
                    if (lastHoverSegment != null)
                    {
                        Color tmp = lastHoverSegment.ColorProp;
                        if(!lastHoverSegment.IsSelected)
                            lastHoverSegment.ColorProp = Color.FromArgb(100, tmp.R, tmp.G, tmp.B);
                        Refresh();
                    }
                }
            
                  
            }
        }

        void CellarPanel_Paint(object sender, PaintEventArgs e)
        {
           if(!DesignMode)
           {
             //  e.Graphics.Clear(Color.Teal);
               for (int i = 0; i < this.Width; i += _iDotDistance)
               {
                   for (int j = 0; j < this.Height; j += _iDotDistance)
                   {

                       _DotSize.X = i;
                       _DotSize.Y = j;
                       e.Graphics.FillEllipse(_DotBrush, _DotSize);
                   }
               }


              // e.Graphics.DrawImage(ClearImage, Point.Empty);
               if(CheckAllSegments(this.StartPoint.X, this.StartPoint.Y))
               e.Graphics.DrawRectangle(new Pen(Color.Black), this.StartPoint.X, this.StartPoint.Y, FinishPoint.X - StartPoint.X, FinishPoint.Y - StartPoint.Y);
               if (ListSegments.Count > 0)
                   foreach (Segments item in ListSegments)
                   {
                       item.Draw(e.Graphics);
                   }
           }
          
        }
        }
    }

