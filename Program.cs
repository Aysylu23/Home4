// Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу.
// Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.
namespace Home4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 7, 10, 12, 16, 19, 22, 35, 26 };
            int number = 26;

            for (int i = 0; i < array.Length; i++) 
            { 
                for (int j = 0; j < array.Length; j++)
                {
                    for(int k = 0; k < array.Length; k++)
                    {
                        if (i == j || i == k || j == k) continue;
                        if (array[i] + array[j] + array[k] == number)
                        {
                            Console.WriteLine($"Числа = {array[i]}, {array[j]}, {array[k]}");
                            return;
                        }

                        
                    }
                }
            }
            Console.WriteLine("Числа не найдены");

        }

    }

}

