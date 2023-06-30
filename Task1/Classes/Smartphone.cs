public class Smartphone : Computer
{
    private int _numberOfSelfies;

    public Smartphone(int ram, int storage, string keyboard, int numberOfSelfies) : base(ram, storage, keyboard)
    {
        _numberOfSelfies = numberOfSelfies;
    }
    public int TakeSelfies()
    {
        return ++_numberOfSelfies;
    }
}