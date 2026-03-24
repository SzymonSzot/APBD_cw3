namespace APBD_cw3;

public class Camera : Item
{
    public string Resolution { get; set; } 
    public string LensType { get; set; }

    public Camera(string name, string resolution, string lensType) : base(name)
    {
        Resolution = resolution;
        LensType = lensType;
    }
}