namespace APBD_cw3;
public abstract class Item
{
    private static int _idGen = 0;
    
    public int Id { get; private set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; } = true;

    protected Item(string name)
    {
        Id = _idGen++; Name = name;
    }
    
    public Item()
    {
    }
}