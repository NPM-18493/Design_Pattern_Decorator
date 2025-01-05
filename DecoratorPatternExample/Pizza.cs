public abstract class Pizza{
    public string Description;

    public virtual string GetDescription(){
        return Description;
    }

    public abstract float GetCost();
}