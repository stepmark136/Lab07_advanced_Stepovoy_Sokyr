// `ChangeName` изменяет объект, видимый снаружи, а `ReplaceHero` не заменяет исходную переменную потому что ChangeName меняет поле обьекта а ReplaceHero только локальную ссылку

// **Вопрос:** почему следующий код не компилируется?

// ```csharp
// void Print(in int value) {
//     value = 10;
// } потому что модификатор in  делает параметр доступным только для чтения


// void DoubleValue(ref int number) {
//     number = number * 2;
// }

// int x = 5;
// DoubleValue(ref x);
// Console.WriteLine(x); 

// void Swap(ref int a, ref int b)
// {
//    int temp = a;
//    a = b;
//    b = temp;
// }
// int x1 = 10;
// int x2 = 20;

// Console.WriteLine($"До обмена: x1 = {x1}, x2 = {x2}");
// Swap(ref x1, ref x2);
// Console.WriteLine($"После обмена: x1 = {x1}, x2 = {x2}");
// // аргументы по умолчанию передаются по значению при вызове Swap(x, y) в метод попадают копии значений переменных



// bool TryDivide(int a, int b, out int result)
// {
//     if (b == 0)
//     {
//         result = 0;
//         return false;
//     }

//     result = a / b;
//     return true;
// }
// int result = 0;
// int a = 5;
// int b = 4;
// Console.WriteLine(TryDivide(a, b, out result));

// bool TryDivide(int dividend, int divisor, out int quotient, out int remainder)
// {
//     if (divisor == 0)
//     {
//         quotient = 0;
//         remainder = 0;
//         return false;
//     }

//     quotient = dividend / divisor;
//     remainder = dividend % divisor;
//     return true;
// }




// struct CharacterStats
// {
//     public int Health;
//     public int Damage;
//     public int Armor;
// }

// class Program
// {
//     static void PrintStats(in CharacterStats stats)
//     {
//         Console.WriteLine($"HP: {stats.Health}");
//         Console.WriteLine($"Урон: {stats.Damage}");
//         Console.WriteLine($"Броня: {stats.Armor}");
//     }

//     static void Main()
//     {
//         var hero = new CharacterStats
//         {
//             Health = 100,
//             Damage = 25,
//             Armor = 15
//         };

//         PrintStats(hero);
//     }
// }


void Print(ref int value)
{
    value = 10;
}
int x = 5;
Print(ref x);
Console.WriteLine(x);
// код не работал потому что параметр с in нельзя изменять

