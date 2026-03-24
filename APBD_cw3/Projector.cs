namespace APBD_cw3;

public class Projector : Item
{
    public int BrightnessLumens { get; set; }
    public string InputInterface { get; set; }

    public Projector(string name, int lumens, string inputInterface) : base(name)
    {
        BrightnessLumens = lumens;
        InputInterface = inputInterface;
    }
}