namespace APBD_cw3;

public class Student : User
{
    public override int Max => 2;

    public Student(string fn, string ln) : base(fn, ln) { }
}