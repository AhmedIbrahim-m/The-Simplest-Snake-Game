

namespace SnakeGamecSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board gridDimentions = new Board(50, 20);
            Board SnakePos = new Board(10, 1);
            Random rand = new Random();
            Board ApplePos = new Board(rand.Next(1, gridDimentions.X-1), rand.Next(1, gridDimentions.Y - 1));
            int FramedelayINMilli = 100;

            Dirrections MoveDirection = Dirrections.Down; 

            List<Board>  SnakePosHistory = new List<Board>();
            int tialLen = 1;
            int score = 0; 

            while (true)
            {
                Console.Clear();
                Console.WriteLine("score : " + score);
             SnakePos.ApplyMovementDirection(MoveDirection);
                
;                for (int y = 0; y < gridDimentions.Y; y++)
                {


                    for (int x = 0; x < gridDimentions.X; x++)
                    {
                        Board Curr = new Board(x, y);
                        if (SnakePos.Equals(Curr))
                            Console.Write("■");
                        else if (ApplePos.Equals(Curr) || SnakePosHistory.Contains(Curr))
                            Console.Write("a");
                        else if (x == 0 || y == 0 || x == gridDimentions.X - 1 || y == gridDimentions.Y - 1)
                            Console.Write("#");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();

                }
                if (SnakePos.Equals(ApplePos)) {
                    tialLen++;
                    score++;
                    ApplePos = new Board(rand.Next(1, gridDimentions.X - 1), rand.Next(1, gridDimentions.Y - 1));
                } else if (SnakePos.X ==0 || SnakePos.Y == 0 || SnakePos.X == gridDimentions.X - 1 || SnakePos.Y == gridDimentions.Y - 1) { 
                     score = 0;
                    tialLen = 1;
                    SnakePos = new Board(10, 1);
                    MoveDirection = Dirrections.Down;
                    continue; 


                     
                }

                SnakePosHistory.Add(new Board(SnakePos.X, SnakePos.Y));
                if (SnakePosHistory.Count > tialLen)
                    SnakePosHistory.RemoveAt(0);

                DateTime time = DateTime.Now;


                while ((DateTime.Now - time).Milliseconds  < FramedelayINMilli)
                {
                    if (Console.KeyAvailable) {
                        ConsoleKey key = Console.ReadKey().Key;

                        switch (key) { 
                         case ConsoleKey.LeftArrow:
                                MoveDirection = Dirrections.Left
                                    ; break;

                            case ConsoleKey.RightArrow:
                                MoveDirection = Dirrections.Right
                                    ; break;
                            case ConsoleKey.DownArrow:
                                MoveDirection = Dirrections.Down
                                    ; break;


                            case ConsoleKey.UpArrow:
                                MoveDirection = Dirrections.Up
                                    ; break;
                        }
                    }
                }

                        
                        
                        }





        }
    }
}
