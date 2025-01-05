public class Onion : ToppingsDecorator
{
    public Onion(Pizza originalPizza){
        OriginalPizza = originalPizza;
    }

    public override float GetCost()
    {
        return OriginalPizza.GetCost() + 50f;
    }

    public override string GetDescription()
    {
        return string.Concat(OriginalPizza.GetDescription(), " + ", "Onion");
    }
}