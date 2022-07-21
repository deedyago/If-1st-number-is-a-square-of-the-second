int number = 0;
int number2 = 0;

Console.Write("Введите первое число: ");
number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
number2 = int.Parse(Console.ReadLine());

if(number > number2)
{   
    int number3 = number2*number2;
    if(number3 == number)
    {  
        Console.Write("Является");
    }
    else
    {   
        Console.Write("Не является");
    }
}
else
{   
    int number3 = number*number;
    if(number3 == number2)
    {  
        Console.Write("Является");
    }
    else
    {   
        Console.Write("Не является");
    }
}