public class PaneerPizza : Pizza
{

    public PaneerPizza(){
        Description = "Paneer Pizza";
    }

    public override float GetCost()
    {
        return 300.0f;
    }
}