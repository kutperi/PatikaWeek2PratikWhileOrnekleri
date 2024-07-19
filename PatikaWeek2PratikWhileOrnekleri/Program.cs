// Burada 10 defa aşağıdaki metni yazdırıyorum.

int i = 0;
while(i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

// Burada 1 ile 20 arasındaki sayıları konsol ekrana yazdırıyorum.

int a = 1;
while (a <= 10)
{
    Console.WriteLine($"Sayı -> {a}");
    a++;
}

// Burada 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırıyorum.

int b = 2;
while (b <= 20)
{
    Console.WriteLine($"Sayı -> {b}");
    b += 2;
}

// Burada 50 ile 150 arasındaki sayıların toplamını ekrana yazdırıyorum.

int toplam = 0;

int c = 50;
while(c <= 150)
{
    toplam += c;
    c++;
}
Console.WriteLine($"Sayıların toplamı -> {toplam}");

// Burada 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırıyorum.

int tekToplam = 0;
int ciftToplam = 0;

int d = 1;
while(d <= 120)
{
    if (d % 2 == 0)
    {
        ciftToplam += d;
    }
    else
    {
        tekToplam += d;
    }
    d++;
}
Console.WriteLine($"1 ve 120 arasındaki tek sayıların toplamı -> {tekToplam}");
Console.WriteLine($"1 ve 120 arasındaki çift sayıların toplamı -> {ciftToplam}");
