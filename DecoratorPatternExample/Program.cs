// See https://aka.ms/new-console-template for more information
Pizza paneerPizza = new PaneerPizza();

//lets add some toppings in paneer pizza
paneerPizza = new Tomato(paneerPizza);
paneerPizza = new Onion(paneerPizza);

Console.WriteLine(paneerPizza.GetDescription());
Console.WriteLine(paneerPizza.GetCost());

Console.WriteLine("******************************");

Pizza chickenPizza = new PaneerPizza();
chickenPizza = new Tomato(chickenPizza);
chickenPizza = new Onion(chickenPizza);
chickenPizza = new Mashroom(chickenPizza);
chickenPizza = new Jalapeno(chickenPizza);

Console.WriteLine(chickenPizza.GetDescription());
Console.WriteLine(chickenPizza.GetCost());

