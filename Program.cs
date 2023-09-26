using System;
using System.Collections.Generic;
using System.Drawing; // Подключение пространства имен для Point класса
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;


namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            Console.SetWindowSize(80, 20);
            Console.ForegroundColor = ConsoleColor.Green;
            Walls walls = new Walls(80, 25);
            walls.Draw();
            Console.ReadLine();
            Console.Clear();


            Team homeTeam = new Team("Home Team");
            Team awayTeam = new Team("Away Team");
            Stadium stadium = new Stadium(80, 25);

            Game game = new Game(homeTeam, awayTeam, stadium);
            game.Start();

            Player player1 = new Player("John", 10, 10, homeTeam);

            Ball ball = new Ball(stadium.Width / 2, stadium.Height / 2, game);
            ball.SetSpeed(1, 1);
            for (int i = 0; i < 10; i++)
            {
                ball.Move();
            }

        }
    }
}
