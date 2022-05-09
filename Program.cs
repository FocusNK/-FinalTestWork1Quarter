string[] array = new string[] { "hello", "2", "world", "Kate", "Tom", "Alice", "As"};
string[] group = Array.FindAll(array, arrayLegth => arrayLegth.Length <= 3);
foreach (var arrayLegth in group)
Console.WriteLine(arrayLegth);