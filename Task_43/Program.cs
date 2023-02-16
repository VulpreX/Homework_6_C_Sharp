int ReadInt(string argument1)
{
    Console.Write($"Enter {argument1}  ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine(" You entered an invalid number, try again!");
    }
    

    return number; 
}

void SearchForAnIntersection(int k1,int b1, int k2, int b2)
{
    double x = Math.Round(new Random().NextDouble(), 2) * 10 ;
    Console.WriteLine($"x={x}");
    double[] array = new double [2];
    array[0] = k1 * x + b1 ;
    array[1] = k2 * x + b2 ;
    Console.WriteLine($"Intersection point = ({array[0]};{array[1]})");
}
SearchForAnIntersection(ReadInt("k1="),ReadInt("b1="),ReadInt("k2="),ReadInt("b2="));