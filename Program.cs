string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(',');

for (int i = 0; i < orders.Length; i++)
{
    char[] letters = orders[i].ToCharArray();

    if (letters.Length == 4)
    {
        Console.WriteLine(orders[i]);
    }
    else
    {
        Console.WriteLine(orders[i] + "\t- Falso");
    }
}