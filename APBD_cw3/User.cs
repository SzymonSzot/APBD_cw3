namespace APBD_cw3;

public abstract class  User
{
    private static int _idGen = 0;
    
    public int Id { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int max { get; protected set; }

    protected  User(string fn, string ln) 
    {
        Id = _idGen++; FirstName = fn; LastName = ln;
    }

    protected User()
    {
    }
}