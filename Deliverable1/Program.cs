// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    Console.WriteLine("Welcome to the restocking tool.");
    Console.WriteLine("How many sodas have been sold today? There are 100 in stock.");
    int soda = int.Parse(Console.ReadLine());
    if (soda > 100)
    {
        Console.WriteLine("Too High. Stock not adjusted.");
    }
    else if (soda <= 100)
    {
        Console.WriteLine("There are " + ((100 - soda)) + (" sodas left."));
    }

    Console.WriteLine("How many chips have been sold today? There are 40 in stock.");
    int chips = int.Parse(Console.ReadLine());
    if (chips > 40)
    {
        Console.WriteLine("Too High. Stock not adjusted.");
    }
    else if (chips <= 40)
    {
        Console.WriteLine("There are " + ((40 - chips)) + (" chips left."));
    }
    Console.WriteLine("How many candies have been sold today? There are 60 in stock.");
    int candies = int.Parse(Console.ReadLine());
    if (candies > 60)
    {
        Console.WriteLine("Too High. Stock not adjusted.");
    }
    else if (candies <= 60)
    {
        Console.WriteLine("There are " + ((60 - candies)) + (" candies left."));
    }


    Console.WriteLine(" Thank you for filling out the values. Here's what needs to be restocked.");
    if ((100 - soda) <= 40)
    {
        Console.WriteLine(" Soda needs to be restocked.");
    }
    if ((40 - chips) <= 20)
    {
        Console.WriteLine(" Chips need to be restocked.");
    }
    if ((60 - candies) <= 40)
    {
        Console.WriteLine(" Candies need to be restocked.");
    }

    Console.WriteLine("Goodbye!");

}
}
