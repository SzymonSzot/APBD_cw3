namespace APBD_cw3;

public class Service
{
    public LinkedList<Renting> Rentings { get; set; }
    public List<User> Users { get; set; }
    public List<Item> Items { get; set; }
    public Service()
    {
        Rentings = new LinkedList<Renting>();
        Users = new List<User>();
        Items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }
    
    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public Item GetItemById(int id)
    {
        foreach (var item in Items)
        {
            if (item.Id == id)
                return item;
        }
        return null;
    }

    public User GetUserById(int id)
    {
        foreach (var usr in Users)
        {
            if (usr.Id == id)
                return usr;
        }
        return null;
    }

    public Renting GetRentingById(int id)
    {
        foreach (var item in Rentings)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
    
    
    public void AddRenting(int userId, int itemId )
    {
        User tmpUser = GetUserById(userId);
        Item tmpItem = GetItemById(itemId);

        if (tmpItem.Equals(null) || tmpUser.Equals(null))
        {
            Console.WriteLine($"Wrong parameters: {userId},  {itemId}");
            return;
        }

        if (!tmpItem.IsAvailable)
        {
            Console.WriteLine($"item unavailable: {itemId}");
            return;
        }

        if (tmpUser.RentedDevices >= tmpUser.Max)
        {
            Console.WriteLine("You cannot add more items than max");
            return;
        }

        Rentings.AddLast(new Renting(tmpItem, tmpUser, DateTime.Now, DateTime.Now.AddMonths(1)));
        tmpItem.IsAvailable = false;
        tmpUser.RentedDevices++;
    }

    public void EndRenting(int rentingId)
    {
        Renting tmpRenting = GetRentingById(rentingId);
        if (tmpRenting.Equals(null))
        {
            Console.WriteLine($"Renting {rentingId} not found");
            return;
        }

        tmpRenting.RentedItem.IsAvailable = true;
        tmpRenting.RentingUser.RentedDevices--;
        Rentings.Remove(tmpRenting);
    }
    
}