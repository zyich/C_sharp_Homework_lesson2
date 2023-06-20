/*
Задача 10: Напишите программу, которая
 принимает на вход трёхзначное число и на выходе 
 показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());
int preresult = num%100 - num%10;
int result = preresult / 10 ;
Console.WriteLine(result);
*/

int GetSecondNum (int num)
{
    
 
    
    int preresult = num%100 - num%10;
    int result = preresult / 10 ;
    return result;
    

}
    Console.WriteLine("Input number");

    int num = Convert.ToInt32(Console.ReadLine());
    int result = GetSecondNum (num ) ;
    Console.WriteLine(result);
