/*Задача 13: Напишите программу, которая выводит
 третью цифру заданного числа
  или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int GetThirdNum (int num)
{
    
 
    
    int preresult = num%10;
    return preresult;
    

}

bool  CheckNumber (int num)
{
    if (num  >= 100 )
    { 
        return true;
    }
    else
    {
        return false;
    }
    
}
   
   
   
   
    Console.WriteLine("Input a number:");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = GetThirdNum(number);
    bool ExistThirdDigit = CheckNumber(number);
        if (ExistThirdDigit)
        {
            Console.WriteLine("The third digit is: " + result);
        }
        else
        {
            Console.WriteLine("There is no third digit in the number.");
        }
    