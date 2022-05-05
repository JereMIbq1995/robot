// using Robot;
namespace Robot {

    class Program {
        static void Main(string[] args) {

            Robot myRobot = new Robot("Jeremy");
            Robot myRobot1 = new Robot("Mr.Robot");

            myRobot.Move("LEFT");
            myRobot1.Scan();
            myRobot.Fire(1000);

            myRobot.SelfDestruct("Self Destructing...");
            myRobot1.SelfDestruct("Self Destructing...");
        }
    }

}