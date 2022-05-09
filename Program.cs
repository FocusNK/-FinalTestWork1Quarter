string[] array = new string[] { "hello", "2", "world", "Kate", "Tom", "Alice", "As" };
string[] group = Array.FindAll(array, arrayLessFour => arrayLessFour.Length <= 3);
foreach (var arrayLessFour in group)
    Console.WriteLine(arrayLessFour);
Console.WriteLine(" ");