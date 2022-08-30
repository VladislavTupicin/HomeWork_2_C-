Console.Clear();

 Console.Write("Введи цифру, дня недели: ");
 int Numberday = Convert.ToInt32(Console.ReadLine());
 

 void CheckingTheDayOfTheWeek (int Numberday) 
 {
   if (Numberday == 6 || Numberday == 7) 
    {
        Console.WriteLine("Ура выходной!");
        Console.WriteLine("Ответ: да");
    }
    else if (Numberday < 1 || Numberday > 7) 
        {
            Console.WriteLine("В неделе 7 дней)");
        }
        else 
        {
            Console.WriteLine("Не выходной(");
            Console.WriteLine("Ответ: нет"); 
        }
 }       

 CheckingTheDayOfTheWeek(Numberday);