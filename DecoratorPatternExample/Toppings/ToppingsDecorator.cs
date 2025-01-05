public abstract class ToppingsDecorator: Pizza
{
    public Pizza OriginalPizza;

    public override abstract string GetDescription();
}