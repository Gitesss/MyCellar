using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellarPanel
{
    class Items
    {
       private string _strSegmentsName;
       private string _strName;

       public string Name
       {
           set
           {
               _strName = value;
           }
           get
           {
               return _strName;
           }
       }

       public string SegmentsName
       {
           set
           {
               _strSegmentsName = value;
           }
           get
           {
               return _strSegmentsName;
           }
       }
    }
}
