using APBD_cw3;

Employee emp1 = new Employee("Szymon", "Szot");
Student st1 = new Student("Szmon", "Szmon");

Camera cam = new Camera("nikon", "4k", "sss");
Projector proj = new Projector("hitachi", 6000, "HDMI");
Laptop lap = new Laptop("Dell", "i5", 8);

Service service = new Service();
service.Items.Add(cam);
service.Items.Add(lap);
service.Items.Add(proj);

service.Users.Add(emp1);
service.Users.Add(st1);

service.AddRenting(1, 1, new DateTime(2026, 03, 27));
service.ShowEquipmentByUser(1);

Console.WriteLine();
service.AddRenting(0, 1, new DateTime(2026, 03, 27));
Console.WriteLine();

service.EndRenting(0);
Console.WriteLine();

service.AddRenting(0, 1, new DateTime(2026, 03, 24));
service.ShowEquipmentByUser(0);

Console.WriteLine();
service.EndRenting(1);

Console.WriteLine();
service.ShowAllEquipment();