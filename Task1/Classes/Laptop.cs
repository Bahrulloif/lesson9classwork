public class Laptop : Computer
{
    private double _weight;

    public Laptop(int ram, int storage, string keyboard, int weight) : base(ram, storage, keyboard)
    {
        _weight = weight;
    }
    public double WeightCheck()
    {
        return _weight;
    }
}