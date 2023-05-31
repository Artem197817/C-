//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("число A в степени В = " + Degree(a,b));
Console.WriteLine("число A в степени В = " + Degree2(a,b));

double Degree (double a,int b){
    return Math.Pow(a,b);
}
double Degree2 (double a, int b){
    double degree = a;
    for (int i = 1;i < b;i++)
        degree *= a;
    return degree;
} 

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
string text = Console.ReadLine();
int length =text.Length;
int num = Convert.ToInt32(text);
int [] array= new int [length];
Fill(num);
Console.WriteLine (" Сумма цифр числа " + num + " - " + Sum());

void Fill (int n){
    for (int i = 0;i < length;i++){
        array[i] = n%10;
        n /= 10;
    }
}
int Sum (){
    int sum = 0;
    foreach (int arr in array)
        sum += arr;
    return sum;
} 

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] arr= new int [8];

Console.WriteLine("Результат выполнения третьей задачи - ");
Fill2();
PrintArr();
Console.WriteLine();

void Fill2 (){
    Random rnd = new Random();
    for (int i = 0;i < arr.Length;i++)
        arr[i] = rnd.Next();
}
void PrintArr (){
    foreach (int ar in arr)
        Console.Write (ar + " ");
}
