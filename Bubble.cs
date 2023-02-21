using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Bubble
    {
        public int height;
        public int width;
        public int posX;
        public int posY;
        public int[] sizes = { 10, 20, 30, 40, 50, 60 };
        public int speedX = 1;
        public int speedY;
        public int topLimit;
        private int moveLimit;

        public Image bubble;
        Random random = new Random();

        public Bubble()
        {
            moveLimit = random.Next(50, 200);
            int i = random.Next(0, sizes.Length);
            bubble = Image.FromFile("images/bubble.png");

            height = sizes[i];
            width = sizes[i];

            topLimit = random.Next(10, 100);
            posX = random.Next(-10, 800);
            posY = random.Next(600, 1200);

            speedY = random.Next(1, 5);
        }


        public void MoveBubble()
        {
            moveLimit -= 1;

            if (moveLimit < 1)
            {
                speedX = -speedX;
                moveLimit = random.Next(50, 200);
            }
        }
    }
}

