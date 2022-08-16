//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Напишите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
if ( b[1] == b[5] & b[2] == b[4])
{ Console.Write("Число является палидромом");
}
else {
    Console.WriteLine("Число не является палидромом"); 
 }