using MLDOTNET_PROJ;

public class Program
{
    private static void Main(string[] args)
    {
        var data = new[]
        {
            new PizzaInfo(){OvenTemp=180, CookingTime=15},
            new PizzaInfo(){OvenTemp=200, CookingTime=12},
            new PizzaInfo(){OvenTemp=220, CookingTime=10},
            new PizzaInfo(){OvenTemp=250, CookingTime=8}
        };

    }
}