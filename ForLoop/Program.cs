// See https://aka.ms/new-console-template for more information

// Exercise 3.a
Console.WriteLine("--------------- Exercise 3.a ----------------");

for (int i = 1; i < 6; i++)
{
    Console.WriteLine("B" + i);
}

Console.WriteLine("--------------- Exercise 3.b ----------------");

for (int i = 7;i < 36; i = i + 7)
{
    Console.WriteLine(i);
}

Console.WriteLine("--------------- Exercise 3.c ----------------");

string strBees = "";

for (int i = 4; i < 9; i++)
{
    strBees = strBees + "B";
    Console.WriteLine( strBees + i);
}