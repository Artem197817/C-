// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число");
string text1 = Console.ReadLine();
if (text1.Length == 3){
    int numb = Convert.ToInt32(text1);
    Console.WriteLine("Вторая цифра - " + (numb/10)%10);
} else {
    Console.WriteLine("Это не трехзначное число");
}


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
string text = Console.ReadLine();
if (text.Length > 2){
    int count = text.Length - 3;
    int num = Convert.ToInt32(text);
    for (int i = 1;i <= count; i++){
        num /=10;
    }
    Console.WriteLine("Третья цифра - " + num%10);
} else {
    Console.WriteLine("Третьей цифры нет");
}

//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");
int numberDay = Convert.ToInt32(Console.ReadLine());
if (numberDay < 1 || numberDay > 7){
    Console.WriteLine("Это число не обозначает день недели");
} else {
if (numberDay >= 1 && numberDay < 6){
     Console.WriteLine("Будний день");
} else {
     Console.WriteLine("Выходной");
}
}

