Console.WriteLine("Введите число");
int numberA = int.Parse(Console.ReadLine());

int count = 1;

while (count <= numberA)
{
    if (count % 2 == 0)
    {
    Console.Write($"{count}");
    }
count ++;
}


