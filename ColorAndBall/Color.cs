using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorAndBall
{
    
    public class Color
    {
        private byte red, green, blue, alpha;
        public Color(byte red, byte green, byte blue)
        {
            alpha = 255;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public void SetColor(Color color)
        {
            this.red = color.red;
            this.green = color.green; 
            this.blue = color.blue;
        }

        public Color GetColor()
        {
            return new Color(red,green,blue);
        }

        public byte GetGrayScale()
        {
            return (byte)((red + green + blue) / 3);
        }
    }
}
