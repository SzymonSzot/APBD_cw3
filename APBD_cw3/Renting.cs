namespace APBD_cw3;

public class Renting
{
    private static int _idGen = 0;
    
    public int Id { get; private set; }
    public Item RentedItem { get; private set; }
    public User RentingUser { get; private set; }
    public DateTime RentDate { get; private set; }
    public DateTime ReturnDate { get; set; }

    public Renting(Item rentedItem, User rentingUser, DateTime rentDate, DateTime returnDate)
    {
        RentedItem = rentedItem;
        RentingUser = rentingUser;
        RentDate = rentDate;
        ReturnDate = returnDate;
        Id = _idGen++;
    }

    public double Overdue()
    {
        if (ReturnDate.CompareTo(DateTime.Now) < 0)
            return ReturnDate.Subtract(DateTime.Now).TotalDays;
        return 0.0;
    }
}