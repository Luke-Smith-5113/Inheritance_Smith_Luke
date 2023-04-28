using System;

namespace Inheritance_Smith_Luke
{
    //abstract class allows you to make a superclass that doesn't actually do anything other than provide things for subclasses
    abstract class Game
    {
        //creates a string feild called ESRB
        public string ESRB
        {
            get; protected set;
        }
        //creates a string feild called Title
        public string Title
        {
            get; set;
        }
        //creates a constructor telling you what you have to specify when making an object
        public Game(string esrb, string title)
        {
            Title = title;
            ESRB = esrb;
        }
        //creates a method that can be accessed by subclasses
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting");
        }
        //creates an abstract string method, which means that it doesn't hold a value here but it does in subclasses of this class
        abstract public string Describe();
    }
    class Shooter : Game
    {
        //created a constructor for the shooter class
        public Shooter(string esrb, string title) : base(esrb, title)
        {

        }
        //creates a describe method
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
            //creates a new shooter object with an ESRB of M and a Title of COD 12
            Shooter shooter = new Shooter("M", "COD 12");
            Console.WriteLine(shooter.Describe());
            shooter.PlayGame();
        }
    }
}
