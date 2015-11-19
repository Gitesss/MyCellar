using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellarPanel
{
    public partial class CellarControl : UserControl
    {
       
        public CellarControl()
        {
            InitializeComponent();
        //    this._DotBrush = new SolidBrush(Color.Black);
        }

        private void CellarPanel_Paint(object sender, PaintEventArgs e)
        {
          //  for(int x = 0; x < this.Width)
          //  e.Graphics.FillEllipse(_DotBrush,)
        }
    }
}
