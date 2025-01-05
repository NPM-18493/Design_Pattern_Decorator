public class Mashroom : ToppingsDecorator
{
    public Mashroom(Pizza originalPizza){
        OriginalPizza = originalPizza;
    }

    public override float GetCost()
    {
        return OriginalPizza.GetCost() + 20f;
    }

    public override string GetDescription()
    {
        return string.Concat(OriginalPizza.GetDescription(), " + ", "Mashroom");
    }
}