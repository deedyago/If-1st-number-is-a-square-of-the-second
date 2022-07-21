int number = 0;
int number2 = 0;
int number3 = 0;

Console.Write("Введите первое число: ");
number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
number2 = int.Parse(Console.ReadLine());

if(number > number2)
{   
        Console.Write("Не является");
    }
else 
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