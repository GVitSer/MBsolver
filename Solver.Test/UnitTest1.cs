using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Solver.Test
{
    [TestClass]
    public class UnitTest1
    {
		//Юнит-тесты
		[TestMethod]
        public void TestAllSolver()
        {
			var r = 10;
			var a = 30;
			var b = 40;
			var c = 50;
			
			var areaCircleResult = AllSolver.AreaCircle(r);
			var areaTriangleResult = AllSolver.AreaTriangle(a, b, c);

			Assert.AreEqual(314, areaCircleResult);
			Assert.AreEqual(1250, areaTriangleResult);
		}
    }
}
