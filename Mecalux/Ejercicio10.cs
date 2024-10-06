﻿public class Ejercicio10
{
    public static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("Fizz & Buzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz"); 
            }
            else
            {
                Console.WriteLine(i);
            }

            /*
                DATOS DE LA EJECUCIÓN:
                1
                2
                Fizz
                4
                Buzz
                Fizz
                7
                8
                Fizz
                Buzz
                11
                Fizz
                13
                14
                Fizz & Buzz
                16
                17
                Fizz
                19
                Buzz
                Fizz
                22
                23
                Fizz
                Buzz
                26
                Fizz
                28
                29
                Fizz & Buzz
                31
                32
                Fizz
                34
                Buzz
                Fizz
                37
                38
                Fizz
                Buzz
                41
                Fizz
                43
                44
                Fizz & Buzz
                46
                47
                Fizz
                49
                Buzz
                Fizz
                52
                53
                Fizz
                Buzz
                56
                Fizz
                58
                59
                Fizz & Buzz
                61
                62
                Fizz
                64
                Buzz
                Fizz
                67
                68
                Fizz
                Buzz
                71
                Fizz
                73
                74
                Fizz & Buzz
                76
                77
                Fizz
                79
                Buzz
                Fizz
                82
                83
                Fizz
                Buzz
                86
                Fizz
                88
                89
                Fizz & Buzz
                91
                92
                Fizz
                94
                Buzz
                Fizz
                97
                98
                Fizz
                Buzz
             */
        }
    }
}