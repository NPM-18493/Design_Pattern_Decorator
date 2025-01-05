public class ChickenPizza : Pizza
{

    public ChickenPizza(){
        Description = "Chicken Pizza";
    }

    public override float GetCost()
    {
        return 350.0f;
    }
}