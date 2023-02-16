int ReadInt(string argument1)
{
    Console.Write($"Enter {argument1} - ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine(" You entered an invalid number, try again!");
    }  

    return number; 
}
void count(int number)
{
    int count= 0;
    
    while (number !=0 )
    {                     
       if(number > 0)
        {
            count++; 
        }
        number= ReadInt(" your number, to stop write 0");        
    }
    System.Console.WriteLine($" Sum numbers > 0 = {count}");
}
count(ReadInt(" your number, to stop write 0"));
