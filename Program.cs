using Sharp_Library;

bool end = false;

ICalc calculator = new FigureCalc();
TriangleValidator validator = new TriangleValidator();

while (!end)
{
    
    try
    {
        Console.Write("Enter the circle radius:");
        double Radius = double.Parse(Console.ReadLine());

        Figure circle = new Circle(Radius);

        double circle_area = calculator.AreaCalc(circle);

        Console.Write("Area of circle:");
        Console.WriteLine(circle_area);
        Console.WriteLine();


        Console.WriteLine("Enter triangle sides:");
        Console.Write("First side:");
        double fist_side = double.Parse(Console.ReadLine());

        Console.Write("Second Side:");
        double second_side = double.Parse(Console.ReadLine());

        Console.Write("Third side:");
        double third_side = double.Parse(Console.ReadLine());

        Figure triangle = new Triangle(fist_side, second_side, third_side);

        double triangle_area = calculator.AreaCalc(triangle);
        bool isright = validator.IsRightTriangle(triangle as Triangle);

        Console.Write("Area of triangle:");
        Console.WriteLine(triangle_area);

        Console.Write("This triangle is right?:");
        Console.WriteLine(isright);
        Console.WriteLine();



    }
    catch (Exception e)
    {

        Console.WriteLine(e.Message);

    }
    finally
    {
        Console.Write("One more? (y/n):");
        string decision = Console.ReadLine(); 
        if (decision=="y")
        {
            end = false;
        }
        else
        {
            end=true;
        }
    }

}






