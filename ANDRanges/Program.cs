//temp <= - Freezing cold
//temp >0 AND temp <- 10 - Cold
//temps > 10 and temp <= - Chilly
//temp >15 AND temp <20 - Warm
//>= 20 AND temp <30 - Hot
//temp >= 30 - Boiling hot

Console.WriteLine("Enter the temperature: ");
int temp = Int32.Parse(Console.ReadLine());

if(temp >= 30)
{
    Console.WriteLine("It's Boiling hot!");
}
else if (temp<30 && temp >= 20)
{
    Console.WriteLine("It's Hot");
}
else if (temp<20 && temp >= 15)
{
    Console.WriteLine("It's Warm");
}
else if (temp<15 && temp >= 10)
{
    Console.WriteLine("It's Chilly");
}
else if (temp<10 && temp >= 0)
{
    Console.WriteLine("It's Cold");
}
else
{
    Console.WriteLine("It's Freezing Cold !");
}