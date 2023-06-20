/* 
Задача 15: Напишите программу, которая
 принимает на вход цифру, обозначающую
  день недели, и проверяет, является
   ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/




bool IsWeekend(int dayOfWeek)
    {
        switch (dayOfWeek)
        {
            case 6:
            case 7:
                return true;
            default:
                return false;
        }
    }

    
        Console.WriteLine("Input a number from 1 to 7 representing a day of the week:");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        bool isWeekend = IsWeekend(dayOfWeek);

        if (isWeekend)
        {
            Console.WriteLine("Yes, it's a weekend.");
        }
        else
        {
            Console.WriteLine("No, it's not a weekend.");
        }
    
