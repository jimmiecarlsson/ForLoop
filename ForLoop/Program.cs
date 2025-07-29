// See https://aka.ms/new-console-template for more information

// Exercise 3.a
Console.WriteLine("--------------- Exercise 3.a ----------------");

for (int i = 1; i < 6; i++)
    Console.WriteLine("B" + i);

    Console.WriteLine("--------------- Exercise 3.b ----------------");

for (int j = 7; j < 36; j = j + 7)
    Console.WriteLine(j);


    Console.WriteLine("--------------- Exercise 3.c ----------------");

    //string strBees = "";

    //for (int i = 4; i < 9; i++)
    //{
    //    strBees = strBees + "B";
    //    Console.WriteLine( strBees + i);
    //}

    // Förenklar

for (int a = 4, b = 0; a < 9; a++, b++)
    Console.WriteLine(new string('B', b) + a);