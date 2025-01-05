public class Jalapeno : ToppingsDecorator
{
    public Jalapeno(Pizza originalPizza){
        OriginalPizza = originalPizza;
    }

    public override float GetCost()
    {
        return OriginalPizza.GetCost() + 40f;
    }

    public override string GetDescription()
    {
        return string.Concat(OriginalPizza.GetDescription(), " + ", "Jalapeno");
    }
}