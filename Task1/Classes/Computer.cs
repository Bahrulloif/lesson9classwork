public abstract class Computer
{
    private int _ram;
    private int _storage;
    private string _keyboard;
    public Computer(int ram, int storage, string keyboard)
    {
        _ram = ram;
        _storage = storage;
        _keyboard = keyboard;
    }
    public int AddRam(int ram)
    {
        return _ram += ram;
    }
    public int AddStorage(int store)
    {
        return _storage += store;
    }

}