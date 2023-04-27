using System;

namespace Inheritance_Smith_Luke
{
    abstract class Game
    {
        public string ESRB
        {
            get; protected set;
        }
        public string Title
        {
            get; set;
        }
        public Game(string esrb, string title)
        {
            Title = title;
            ESRB = esrb;
        }
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting");
        }
        abstract public string Describe();
    }
    class Shooter : Game
    {
        public Shooter(string esrb, string title) : base(esrb, title)
        {

        }
        override public string Describe()
        {
            string describe = $"this game is a Shooter game titled {Title}, and an esrb rating of {ESRB}";
            return describe;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shooter shooter = new Shooter("M", "COD 12");
            Console.WriteLine(shooter.Describe());
            shooter.PlayGame();
        }
    }
}
