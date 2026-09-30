namespace RobotPrototype
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public ServiceRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion,
            string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override IRobotPrototype Clone()
        {
            return new ServiceRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                ServiceTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Service Robot");
            base.DisplayDetails();
            Console.WriteLine("Service Task: " + ServiceTask);
        }
    }
}