using CellarPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCellar
{
    public interface ISetName
    {
        string Name { set; get; }
        List<Segments> SegmentsList { set; }
        List<string> ItemsList { set; }
        string ActualSelectedSegment { set; }
    }
}
