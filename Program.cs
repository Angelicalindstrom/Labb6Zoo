namespace Labb6Zoo
{
    internal class Program
    {

        // Angelica Lindström NET.23
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyZoo !\n");


            // creating all the animals from all the classes 
            Lion MyLion = new Lion("Edvard", "Lion", "Yellow", 10, 190, "Peeing","Family");
            Snake Mysnake = new Snake("Sting, Cobbie, and Tyson", "Snakes", "Green, Yellow, Red", 60, 100, 
                "Scales", 9);
            Bird MyBird = new Bird("Happy and SingSing", "Birds", "Blue and Orange", 15, 1, "Black and long", 
                "3 toes in the front, 1 toe backwards");
            Parrot MyParrot = new Parrot("Smartie","Parrot", "Red, Yellow, Blue", 54, 2, "White", 
                "2 toes forward, 2 backwards", "Mimic us humans and sing");
            Eagle MyEagle =new Eagle("Speedy","Sea Eagle","White head, Brown body and wings", 12, 6,"Yellow and sharp",
                "3 toes in the front,1 toe backwards, sharp claws",120,2.05);


            // Lion
            MyLion.MakeSound();
            Console.WriteLine("\nThe Lion At MyZoo");
            MyLion.InfoLion();
            Console.WriteLine("\nSome other fun facts about the lions:");
            MyLion.Sound();
            MyLion.Eat();
            MyLion.Move();
            MyLion.Play();

            Console.Write("\nLet´s head over to the SnakeCenter, Follow me!\n\n");

            // Snake
            Console.WriteLine("\n\nWelcome to the Snake Center here at MyZoo!!\n");
            Mysnake.MakeSound();
            Mysnake.InfoSnake();
            Console.WriteLine("\nSome other fun facts about the snakes:");
            Mysnake.Sound();
            Mysnake.Eat();
            Mysnake.Move();
            Mysnake.SkinPeel();


            Console.Write("\nLet´s head over to the birdCage!\n\n");

            // Bird
            Console.WriteLine("\n\nWelcome to the BirdCage here at MyZoo!!\n");
            MyBird.MakeSound();
            MyBird.InfoBird();
            Console.WriteLine("\nSome other fun facts about birds:");
            MyBird.Sound();
            MyBird.Eat();
            MyBird.Move();
            MyBird.Fly();

            Console.Write("\nNow you´ll get the chanse to meet two of our favorite birds!\n\n\n");

            // Parrot
            Console.WriteLine("\n\nSay Hi to our Parrot!!\n");
            MyParrot.MakeSound();
            MyParrot.InfoParrot();
            Console.WriteLine("\nSome other fun facts about birds:");
            MyParrot.Sound();
            MyParrot.Eat();
            MyParrot.Move();
            MyParrot.Dance();

            Console.Write("\nNow we´ll head over to see our gratest hunter in action!\n\n\n");

            // Eagle
            Console.WriteLine("\n\nSay Hi to our Sea Eagle!!\n");
            MyEagle.MakeSound();
            MyEagle.InfoParrot();
            Console.WriteLine("\nSome other fun facts about birds:");
            MyEagle.Sound();
            MyEagle.Eat();
            MyEagle.Move();
            MyEagle.Hunting();



            Console.Write("\nThat´s All for Today People!! Thank you for visiting MyZoo!! Welcome Back!\n\n");


        }
    }
}