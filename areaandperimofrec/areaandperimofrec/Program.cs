namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int shortSide, longSide, perimeter, area;
            Console.WriteLine("enter the length of the short side: ");
            shortSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the length of the long side: ");
            longSide = Convert.ToInt32(Console.ReadLine());

            perimeter = (shortSide + longSide) * 2;
            area = shortSide * longSide;

            Console.WriteLine("The perimeter of the rectangle: " + perimeter);
            Console.WriteLine("The area of the rectangle: " + area);
            Console.ReadLine();
        }

    }

}