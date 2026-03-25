namespace APBD_cw3;

public abstract class  User
{
    private static int _idGen = 0;
    
    public int Id { get; private set; }
    
    public int RentedDevices { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public abstract int Max { get;}

    protected  User(string fn, string ln) 
    {
        Id = _idGen++; FirstName = fn; LastName = ln; RentedDevices = 0;
    }
}