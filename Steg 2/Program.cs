using System.Runtime.CompilerServices;
using System.Security.Authentication;

// List<string> Items = ["Ball", "Lego", "Doll", "Action Figure", "Stuffed Animal"];

// foreach (string Item in Items)
// {
//     Console.WriteLine(Item);
// }

// List<string> Names = ["Phatchara", "Teodora", "Liam", "Andreas", "Mande"];

// List<int> Numbers = [2, 4, 5, 7, 9, ];

// for (int i = 0; i < Names.Count; i++)
// {
//     Console.WriteLine($"{Names[i]} får en {Items[i]} för {Numbers[i]} kr");
// }


List<string> cities = new List<string>();
string input;

while (true)
{
    System.Console.WriteLine("Enter the name of a city");
    input = Console.ReadLine();
    while (string.IsNullOrEmpty(input))
    {
        System.Console.WriteLine("Please enter the name of a city");
        input = Console.ReadLine();
    }

    cities.Add(input);

    if (input == "exit")
    {
        break;
    }

    for (int i = 0; i < cities.Count; i++)
    {
        System.Console.WriteLine(cities[i]);
    }

}


Console.ReadLine();