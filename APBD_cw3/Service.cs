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
    
    
    public void AddRenting(int userId, int itemId , DateTime returnDate)
    {
        User tmpUser = GetUserById(userId);
        Item tmpItem = GetItemById(itemId);

        if (tmpItem == null || tmpUser == null)
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

        Rentings.AddLast(new Renting(tmpItem, tmpUser, DateTime.Now, returnDate));
        tmpItem.IsAvailable = false;
        tmpUser.RentedDevices++;
    }

    public void EndRenting(int rentingId)
    {
        Renting tmpRenting = GetRentingById(rentingId);
        if (tmpRenting == null)
        {
            Console.WriteLine($"Renting {rentingId} not found");
            return;
        }

        tmpRenting.RentedItem.IsAvailable = true;
        tmpRenting.RentingUser.RentedDevices--;
        tmpRenting.RealReturnDate = DateTime.Now;
        
        Console.WriteLine($"Renting {rentingId} has been rented");
        Console.WriteLine($"Overdue penalty {tmpRenting.Penalty()}");
    }
    
    public void ShowAllEquipment()
    {
        Console.WriteLine("--- All Equipment ---");
        foreach (var item in Items)
        {
            string status = item.IsAvailable ? "Available" : "Rented";
            Console.WriteLine($"ID: {item.Id} {item.Name} | Status: {status}");
        }
    }
    
    public void ShowAllRentedEquipment()
    {
        Console.WriteLine("--- Currently Rented Items ---");
        foreach (var renting in Rentings)
        {
            Console.WriteLine($"Item ID: {renting.RentedItem.Id} | Rented by User: {renting.RentingUser.Id} | Due: {renting.ReturnDate}");
        }
    
        if (Rentings.Count == 0)
            Console.WriteLine("No items are currently rented.");
    }
    
    public void ShowEquipmentByUser(int userId)
    {
        User user = GetUserById(userId);
        if (user == null)
        {
            Console.WriteLine($"User with ID {userId} not found.");
            return;
        }

        Console.WriteLine($"--- Equipment rented by User {userId} ---");
        bool found = false;
        foreach (var renting in Rentings)
        {
            if (renting.RentingUser.Id == userId)
            {
                Console.WriteLine($"Item ID: {renting.RentedItem.Id} | Return Date: {renting.ReturnDate}");
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("This user has no active rentals.");
    }
}