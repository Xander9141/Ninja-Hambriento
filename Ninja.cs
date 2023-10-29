class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;

    // add a constructor
    public Ninja() {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }

    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
        get { return calorieIntake > 1200; } // Valor arbitrario, depende de la capacidad del Ninja
    }

    // build out the Eat method
    public void Eat(Food item)
{
    if (!IsFull)
    {
        FoodHistory.Add(item);
        calorieIntake += item.Calories;

        Console.Write($"El ninja ha comido {item.Name}. ");
        if (item.IsSpicy)
            Console.Write("Es picante. ");
        else if (item.IsSweet)
            Console.Write("Es dulce. ");
        else
            Console.Write("No es ni picante ni dulce. ");

        Console.WriteLine($"La ingesta calórica es ahora: {calorieIntake}");
    }
    else
    {
        Console.WriteLine("El ninja está lleno y no puede comer más. ¡No hay más comida!");
    }
}

}



