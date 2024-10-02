using System;

class MyClass
{
    static void Main()
    {
        int tekSayıToplamı = 0;
        int çiftSayıToplamı = 0;

        for (int i = 0; i <= 120; i++)
        {
            if (i % 2 == 0)
            {
                çiftSayıToplamı += i;
            }
            else
            {
                tekSayıToplamı += i;
            }
        }
        Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı:    " + çiftSayıToplamı);
        Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı :    " +  tekSayıToplamı);

        Console.ReadKey();

    }
}