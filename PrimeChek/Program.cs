Console.WriteLine("---------Asal Sayı Doğrulama Uygulaması---------\n");
Console.WriteLine("---------Hoşgeldiniz---------\n\n");

var flag = true;

while (flag)
{
    Console.Write("Lütfen Bir Sayı Giriniz:");
    double number;
    int counter = 0;
    var isPrime = double.TryParse(Console.ReadLine(), out number);
    if (isPrime)
    {
        var boundary = (int)Math.Floor(Math.Sqrt(number));
        if (number == 2 || number == 0 || number % 2 == 0)
        {
            Console.WriteLine($"Girilen Sayı = {number} Asal Değildir.\n ");
        }
        else if (number != 0)
        {
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                {
                    counter++;
                }
            if (counter != 0)
            {
                Console.WriteLine($"Girilen Sayı = {number} Asal Değildir.\n ");
            }
            else
            {
                Console.WriteLine($"Girdiğiniz {number} Asal Sayıdır!\n");
            }
        }
    }
    else
    {
        Console.WriteLine("Yanlış Bir Giriş Yaptınız!\n");
    }

    flag = WantToCont();
}

bool WantToCont()
{
    var flag = true;
    while (flag)
    {
        Console.Write("Devam Etmek İstiyor Musunuz ? (EVET-e, HAYIR-h)\n");
        string input = Console.ReadLine().ToLower();
        if (input == "e" || input == "evet")
        {
            flag = false;
            return true;
        }
        else if (input == "h" || input == "hayır")
        {
            Console.WriteLine("Hoşçakalın :)");
            return false;
        }
        else
        {
            Console.WriteLine("Yanlış Giriş Yaptınız. Lütfen Tekrar Deneyiniz.");
            flag = true;
        }
    }
    return false;
}

Console.ReadKey();