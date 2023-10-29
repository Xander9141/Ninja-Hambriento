using System;
using System.Collections.Generic;
class Buffet
{
    public List<Food> Menu;

    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Hamburgesa", 100, false, false),
            new Food("HotDog", 90, false, false),
            new Food("Arroz Chino", 50, true, false),
            new Food("Pizza", 120, false, false),
            new Food("Pie de limon", 85, false, true),
            new Food("Chile al jugo", 30, true, false),
            new Food("Sopaipilla", 20, false, false)

        };
    }

    public Food Serve()
    {
        Random random = new Random();
        int randomIndex = random.Next(Menu.Count);
        return Menu[randomIndex];
    }
}

