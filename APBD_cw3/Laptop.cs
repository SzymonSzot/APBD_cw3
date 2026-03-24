namespace APBD_cw3;

public class Laptop : Item
{
    public string Processor { get; set; }
    public int RamGb { get; set; }
    public Laptop(string name, string cpu, int ram) : base(name) 
    {
        Processor = cpu;
        RamGb = ram;
    }
}