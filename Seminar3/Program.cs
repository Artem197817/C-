//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*Console.WriteLine("Введите число");
string text = Console.ReadLine();
int length =text.Length;
int num = Convert.ToInt32(text);
int isPal = 1;
if (length > 2){
    int [] arr = new int [length];
    for (int i = 0;i < length;i++){
        arr[i] = num%10;
        num /= 10;
    }
    for (int i = 0;i < (length-1)/2;i++){
        if (arr[i] == arr[length - 1 - i]){
            continue;
        } else {
            isPal = -1;
            break;
        }    
    }
} else { 
    if (length == 2 && num/10 != num%10) 
        isPal = -1;
}
 Console.WriteLine(isPal == 1? text + " -> да":text + " -> нет"); */
    
    
// Для добуквенного исполнения задания нужнa проверкa на пятизначность. Но в данной версии
// проверяет любое число на палиндромность. Проще решить можно было через символы.







//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N + " -> ");
for (int i = 1;i <= N;i++)
    Console.Write(i < N? Math.Pow(i,3) + ",":Math.Pow(i,3));
Console.WriteLine();*/





