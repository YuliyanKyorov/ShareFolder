﻿int age = int.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

if (gender == 'f')
{
    if (age >= 16)
    {
        Console.WriteLine("Ms.");
    }
    else
    {
        Console.WriteLine("Miss");
    }
}
else if (gender == 'm')
{
    if (age >= 16)
    {
        Console.WriteLine("Mr.");
    }
    else
    {
        Console.WriteLine("Master");
    }
}
