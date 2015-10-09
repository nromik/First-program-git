using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program_git.git
{
    class Point
    {
        private int x, y;
        public Point()
        {
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
       public int X
       {
            set
            {
                this.x = value;
            }
            get
            {
                return this.x;
            }
        }
       public int Y
       {
           set
           {
               this.y = value;
           }
           get
           {
               return this.y;
           }
       }
    }
}
