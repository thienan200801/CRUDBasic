using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBasic
{
    public class RectLogic
    {
        int width, height;
        public int getWidth() { return width; }
        public int getHeight() { return height; }
        public void setWidth(int wid) { this.width = wid; }
        public void setHeight(int hei) { this.height = hei; }

        public RectLogic(int width = 0, int height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public int Area()
        {
            return this.width * this.height;
        }
        public int Perimeter()
        {
            return 2 * (this.width + this.height);
        }
    }
}
