internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int Ax = 1; //new Random().Next(1, 5);
        int Ay = 1; //new Random().Next(1, 5);
        int Bx = 1; //new Random().Next(1, 5);
        int By = 30; //new Random().Next(10, 30);

        int Cx = 60; // new Random().Next(40, 50);
        int Cy = 30; //new Random().Next(10, 25);
        Console.SetCursorPosition(Ax, Ay);
        Console.WriteLine("+");
        Console.SetCursorPosition(Bx, By);
        Console.WriteLine("+");
        Console.SetCursorPosition(Cx, Cy);
        Console.WriteLine("+");

        int x = Ax, y = Ay; 
int count = 10;

        while (count < 1000)
        {
            int what = new Random().Next(0, 3); // [0;3)
            if (what == 0)
            {
                x = (x + Ax) / 2;
                y = (y + Ay) / 2;
            }
            if (what == 1)
            {
                x = (x + Bx) / 2;
                y = (y + By) / 2;
            }
            if (what == 2)
            {
                x = (x + Cx) / 2;
                y = (y + Cy) / 2;
            }
            Console.SetCursorPosition(x, y);
            Console.WriteLine("+");

            count = count + 1;
        }
    Console.SetCursorPosition(60, 32);
    }
}