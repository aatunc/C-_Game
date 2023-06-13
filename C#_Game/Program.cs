int games;
int min = 1;
int max = 100;
Random rand = new Random();
int number  = rand.Next(min, max + 1);
int gamens  = 0;

do
{
    Console.Write("Geben Sie Zahl zwischen {0} und {1} ein: ", min, max);
    games = Convert.ToInt32(Console.ReadLine());
    gamens += 1;

    if (gamens == number)
    {
        Console.WriteLine("Richtig! Die Zahl war " + number);
        Console.WriteLine("Sie haben {0} Versuche gebraucht!", gamens);
    }
    else if (games > number)
    {
        Console.WriteLine("Die Zahl ist kleiner als " + games);

    }
    else if (games < number)

    {
        Console.WriteLine("Die Zahl ist größer als " + games);
    }
    Console.WriteLine();

}
while (games != number);