List<int> list = new List<int>() {1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};
System.Console.Write("MAX ELEMENT: ");
System.Console.Write(list.Max());
System.Console.WriteLine("\n<===================>");

System.Console.WriteLine("SORTED ELEMENT: ");
list.Sort();
foreach (var it in list)
{
    System.Console.Write(it+" ");
}

System.Console.WriteLine();
System.Console.WriteLine("<=================>");
System.Console.WriteLine("IF in the list has elemen < 0 do it 0:\n <===============================>");

for (int i = 0; i < list.Count; i++)
{
        if(list[i]<0)
        {
           list[i] = 0;
        }
        System.Console.Write(list[i]+ " ");
}

