Console.WriteLine("Введите чило A");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите чило B");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;

if (numberA > numberB) max = numberA;
if (numberA < numberB) max = numberB;

Console.Write("Max = ");
Console.WriteLine(max);
