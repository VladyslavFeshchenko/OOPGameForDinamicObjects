using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace OOPGame
{
    public class Obstacle : IGameObject
    {
        public int x, y, w, h;
        public int speed;

        public Obstacle(int x, int y, int speed)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
        }

        public void Render(ConsoleGraphics graphics)
        {
            graphics.FillRectangle(0xFFFF0000, x, y, 50, 50);
        }

        public void Update(GameEngine engine)
        {
            y += speed;

            if (y>=500 || y<=0)
            {
                speed *= -1;
            }
        }
    }
}
