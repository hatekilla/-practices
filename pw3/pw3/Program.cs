using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw3
{
    class color
    {
        private int red;
        private int green;
        private int blue;

        //
        public int Red
        {
            get { return Red; }
            set { Red = NormalizeColorValue(value); }
        }
        public int Green
        {
            get { return Green; }
            set { Green = NormalizeColorValue(value); }
        }
        public int Blue
        {
            get { return Blue; }
            set { Blue = NormalizeColorValue(value); }
        }
        //
        public color( int red, int green, int blue)
        {
            red = Red;
            green = Green;
            blue = Blue;
        }
        public void DisplayColor()
        {
            Console.WriteLine($"{red}, {green}, {blue}");
        }
        private int NormalizeColorValue (int ColorValue)
        {
            if (ColorValue > 255)
            {
                return 255;
            }
            if (ColorValue < 0) {
                return 0;
            }

            return ColorValue;
        } 
    }
}
