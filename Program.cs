//Решение с семинара
/*Console.Write("Введите 3-значное число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("последняя цифра числа " + n + " = " + n % 10);
Console.WriteLine($"последняя цифра числа {n} = {n % 10}");*/



// Программа, принимающая на вход 3-х значное число, а на выходе показывает последнюю цифру этого числа
/*Попыталась написать программу, не получается присвоить переменные каждому по очереди введенному числу.
 Не получается это сделать*/


Console.WriteLine("Введите 3-значное число: ");
int numbers = int.Parse(Console.ReadLine());

int one = int.Parse(Console.ReadLine());
int two = int.Parse(Console.ReadLine());
int tree = int.Parse(Console.ReadLine());
int number1 = one;
int number2 = two;
int number3 = tree;
numbers = int.Parse($"Console.ReadLine{one}{two}{tree}");

Console.WriteLine(tree);
