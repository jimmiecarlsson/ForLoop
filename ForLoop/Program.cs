// See https://aka.ms/new-console-template for more information



//// Exercise 3.a
//Console.WriteLine("--------------- Exercise 3.a ----------------");

//for (int i = 1; i < 6; i++)
//{
//    Console.WriteLine("B" + i);
//}

//// Exercise 3.b
//Console.WriteLine("--------------- Exercise 3.b ----------------");

//for (int j = 7; j < 36; j = j +7)
//{
//    Console.WriteLine(j);
//}

//// Exercise 3.c
//Console.WriteLine("--------------- Exercise 3.c ----------------");

//string strBees = "";

//for (int i = 4; i < 9; i++)
//{
//    strBees = strBees + "B";
//    Console.WriteLine(strBees + i);
//}


// Förenklat

// Exercise 3.a
Console.WriteLine("--------------- Exercise 3.a ----------------");

for (int i = 1; i < 6; i++)
    Console.WriteLine("B" + i);

// Exercise 3.b
Console.WriteLine("--------------- Exercise 3.b ----------------");

for (int j = 7; j < 36; j = j + 7)
    Console.WriteLine(j);

// Exercise 3.c
Console.WriteLine("--------------- Exercise 3.c ----------------");

for (int a = 4, b = 0; a < 9; a++, b++)
    Console.WriteLine(new string('B', b) + a);