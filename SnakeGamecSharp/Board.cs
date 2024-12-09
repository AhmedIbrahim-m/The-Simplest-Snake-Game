using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGamecSharp
{
    internal class Board
    {
        private int x, y;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public Board(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public override bool Equals(object? obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType())) return false;

            Board other = (Board)obj;
            return x == other.x && y == other.y;

        }
        public void ApplyMovementDirection(Dirrections Dr)
        {
            {
                switch (Dr)
                {
                    case Dirrections.Left:
                        x--; break;
                    case Dirrections.Right:
                        x++; break;
                    case Dirrections.Up:
                        y--; break;
                    case Dirrections.Down:
                        y++; break;

                }
            }


        }
    }
}
