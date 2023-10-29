using System;

class Program
{
    static void Main()
    {
        Buffet buffet = new Buffet();
        Ninja ninja = new Ninja();

        Food food;
        while (!ninja.IsFull)
        {
            food = buffet.Serve();
            ninja.Eat(food);
        }
    }
}
