namespace Lab08
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Circle circle = new Circle(1, 5, 9);
            Elipse elipse = new Elipse(1, 1, 8, 5);
            circle.CircleDisplay();
            Console.WriteLine("----------------------------------------------");
            elipse.ElipseDisplay();
        }
    }
}