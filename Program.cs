/*Console.WriteLine("Введите сколько сахара вы хотите");
string input = Console.ReadLine();
int num = Convert.ToInt32(input);

int kolvo = 1;

while (kolvo <= num)
{
    Console.WriteLine("Добавили" + kolvo + "ложек сахара");
    kolvo++;
}*/

int num;
do
{

    Console.WriteLine("Какой цвет вы любите?");
    Console.WriteLine("1. Красный");
    Console.WriteLine("2. Голубой");
    Console.WriteLine("3. Салатовый");
    Console.WriteLine("4. Фиолетовый");
    Console.WriteLine("5. Выход");

    //1 вариант
    //string input = Console.ReadLine();
    //int num = Convert.ToInt32(input);

    //2 вариант
    //int num = Convert.ToInt32(Console.ReadLine());

    //3 вариант
    int.TryParse(Console.ReadLine(), out num);
} while (num != 5);

