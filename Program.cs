//Написать программа, которая из имеющего массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[] { "hello", "2", "world", "Kate", "Tom", "Alice", "As"};
string[] group = Array.FindAll(array, arrayLegth => arrayLegth.Length <= 3);
foreach (var arrayLegth in group) 
Console.WriteLine(arrayLegth);
// Tom Sam Bob Tom