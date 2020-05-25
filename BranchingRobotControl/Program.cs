using System;

namespace BranchingRobotControl
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Fire?:{ShouldFire(true,"boss1",12)}");
        }
		static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
		{
			//bool shouldFire = true;
			//if (enemyInFront == true)
			//{
			//	if (enemyName == "boss")
			//	{
			//		if (robotHealth < 50) shouldFire = false;
			//		if (robotHealth > 100) shouldFire = true;
			//	}
			//}
			//else
			//{
			//	return false;
			//}
			//return shouldFire;
			return enemyInFront && !(enemyName=="boss" && robotHealth<50);
		}
	}
}
