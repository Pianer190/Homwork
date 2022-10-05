//Напишите программу которая будет выдовать значения дня недели по заданному номеру 

Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

string[] days = { "Понидельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };//Массив
if (day < 1 || day > 7)
{

Console.WriteLine("Такого дня недели не существует");

}

else{

// add line in console
Console.WriteLine(days[day+1]);

}
