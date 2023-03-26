namespace TheFifthHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter quadcopter = new Quadcopter();
            quadcopter.Charge();
            Console.WriteLine(((IFlyingRobot)quadcopter).GetRobotType());
            Console.WriteLine(((IRobot)quadcopter).GetRobotType());
        }
    }
}