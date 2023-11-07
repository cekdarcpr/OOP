namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Tutorial tutorial = new Tutorial();

            tutorial.setTutorial(52,"Çekdar");

            Console.WriteLine(tutorial.getTutorialName());

            Console.ReadKey();
        }

    }
}