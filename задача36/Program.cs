// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 100);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}
int SummaOddIndex(int[] array)
{
    int sum = 0;
    int i =1;
    while (i < array.Length)
    {
        sum =sum+array[i];
        i=i+2;
    }
    return sum;    
}
Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt16(Console.ReadLine());

int[] numbers = new int[n];
FillArray(numbers);
PrintArray(numbers);

