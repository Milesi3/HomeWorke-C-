while (true)
{
Console.WriteLine("Выберите задачу котрую бы выхотели решить:");
Console.WriteLine("1 - Задача 2: два числа. Опредляет max min");
Console.WriteLine("2 - Задача 4: три числа. Опредляет max");
Console.WriteLine("3 - Задача 6: Четное ли число?");
Console.WriteLine("4 - Задача 8: все четные числа от 1 до N");
Console.WriteLine("5 - Выход");
Console.Write("Выберите пункт меню: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.Write("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    

    if(number1>number2) 
    {
        Console.Write("max: ");
        Console.WriteLine(number1);
        Console.Write("min: ");
        Console.WriteLine(number2);
    }
    else 
    {
        Console.Write("max: ");
        Console.WriteLine(number2);
        Console.Write("min: ");
        Console.WriteLine(number1);
    }
}

if (number == 2)
{
    Console.Write("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int number3 = Convert.ToInt32(Console.ReadLine());

    if (number1>number2)
    {
        if (number1>number3)
        {
            Console.Write("max: ");
            Console.WriteLine(number1);
        }
        else
        {
            Console.Write("max: ");
            Console.WriteLine(number3);
        }
    }
    else 
    {
        if (number2>number3)
       {
            Console.Write("max: ");
            Console.WriteLine(number2);
       } 
       else 
        {
            Console.Write("max: ");
            Console.WriteLine(number3);
       } 
    }   
    
}

if (number == 3)
{
    Console.Write("Введите число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    if (number1 % 2 == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

if (number == 4)
{
    Console.Write("Введите число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    int temp = 0;
    if (number1 % 2 == 0)
    {
        while (number1 > temp)
        {
            temp = temp + 2;
            Console.WriteLine(temp);
        }
    }
    else 
    {
        number1 = number1 - 1;
        while (number1 > temp)
        {
            temp = temp + 2;
            Console.WriteLine(temp);
        }
    }
}

if (number == 5)
{
    break;
}

}