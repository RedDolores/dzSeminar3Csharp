// Написать метод для разворота массива, 
// не используя память под дополнительный массив


Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for(int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i + 1} число массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}


int tmp = 0;

for(int i = 0; i < n / 2; i++)
{
    tmp = array[i];
    array[i] = array[n - 1 - i];
    array[n - 1 - i] = tmp;
}


for(int i = 0; i < n; i++)
{
    Console.WriteLine(array[i]);

}