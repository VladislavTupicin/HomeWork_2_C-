Console.Clear();

 Console.Write("Введи число: ");

 int anyNumber = Convert.ToInt32(Console.ReadLine());
 string answer = Convert.ToString(anyNumber);

 if (answer.Length > 2)
 {
   Console.WriteLine("Ответ: " + answer[2]);
 }
 else 
 {
   Console.WriteLine("Третьей цифры нет");
 }