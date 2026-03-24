namespace APBD_cw3;

public class Employee : User
{
    public override int Max => 5;

    public Employee(string fn, string ln) : base(fn, ln) { }
}