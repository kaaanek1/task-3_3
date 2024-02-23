abstract class Parent: IParent, IPrinter
{
    protected bool fill = false;

    protected static Random rnd = new Random();

    protected abstract void UserFill();

    protected abstract void RndFill();
    
    public abstract void Average();

    public abstract void Print();

}

