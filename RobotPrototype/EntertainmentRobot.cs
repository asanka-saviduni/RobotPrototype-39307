namespace RobotPrototype
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion,
            string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            EntertainmentFeature = entertainmentFeature;
        }

        public override IRobotPrototype Clone()
        {
            return new EntertainmentRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                EntertainmentFeature);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Entertainment Robot");
            base.DisplayDetails();
            Console.WriteLine("Entertainment Feature: " + EntertainmentFeature);
        }
    }
}