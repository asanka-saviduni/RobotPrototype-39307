using RobotPrototype;

ServiceRobot serviceRobot = new ServiceRobot(
    "SR-100",
    12,
    "v1.0",
    "Patient Assistance");

IndustrialRobot industrialRobot = new IndustrialRobot(
    "IR-200",
    24,
    "v2.1",
    "Welding");

EntertainmentRobot entertainmentRobot = new EntertainmentRobot(
    "ER-300",
    10,
    "v1.5",
    "Dancing");

ServiceRobot clonedServiceRobot =
    (ServiceRobot)serviceRobot.Clone();

clonedServiceRobot.BatteryCapacity = 15;
clonedServiceRobot.SoftwareVersion = "v1.1";

IndustrialRobot clonedIndustrialRobot =
    (IndustrialRobot)industrialRobot.Clone();

clonedIndustrialRobot.BatteryCapacity = 30;
clonedIndustrialRobot.SoftwareVersion = "v2.2";

EntertainmentRobot clonedEntertainmentRobot =
    (EntertainmentRobot)entertainmentRobot.Clone();

clonedEntertainmentRobot.BatteryCapacity = 14;
clonedEntertainmentRobot.SoftwareVersion = "v1.6";

Console.WriteLine("Original Service Robot");
serviceRobot.DisplayDetails();

Console.WriteLine("\nCloned Service Robot");
clonedServiceRobot.DisplayDetails();

Console.WriteLine("\nOriginal Industrial Robot");
industrialRobot.DisplayDetails();

Console.WriteLine("\nCloned Industrial Robot");
clonedIndustrialRobot.DisplayDetails();

Console.WriteLine("\nOriginal Entertainment Robot");
entertainmentRobot.DisplayDetails();

Console.WriteLine("\nCloned Entertainment Robot");
clonedEntertainmentRobot.DisplayDetails();