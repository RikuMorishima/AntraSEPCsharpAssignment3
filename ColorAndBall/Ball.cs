using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorAndBall
{
    public class Ball
    {
        Color color;
        int size;
        int thrown;

        public Ball(Color color, int size, int thrown)
        {
            this.color = color;
            this.size = size;
            this.thrown = thrown;
        }

        public Ball(Color color, int size)
        {
            this.color = color;
            this.size = size;
            thrown = 0;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if (this.size !=0)
                ++this.thrown;
        }

        public int GetThrown()
        {
            return thrown;
        }
    }
}
