namespace TheFifthHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter quadcopter = new Quadcopter();
            quadcopter.Charge();
            var a = quadcopter as IFlyingRobot;
            var b = quadcopter as IRobot;
            Console.WriteLine(a.GetRobotType());
            Console.WriteLine(b.GetRobotType());
        }
    }
}