namespace RobotPrototype
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public IndustrialRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion,
            string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        public override IRobotPrototype Clone()
        {
            return new IndustrialRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                IndustrialTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Industrial Robot");
            base.DisplayDetails();
            Console.WriteLine("Industrial Task: " + IndustrialTask);
        }
    }
}