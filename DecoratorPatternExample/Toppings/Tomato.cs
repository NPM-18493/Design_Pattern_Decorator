public class Tomato : ToppingsDecorator
{
    public Tomato(Pizza originalPizza){
        OriginalPizza = originalPizza;
    }

    public override float GetCost()
    {
        return OriginalPizza.GetCost() + 30f;
    }

    public override string GetDescription()
    {
        return string.Concat(OriginalPizza.GetDescription(), " + ", "Tomato");
    }
}