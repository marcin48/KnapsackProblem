using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        //Test 1
        // Sprawdzenie czy jeśli conajmniej jeden przedmiot spełnia oraniczenie to czy jest zwracany
        [TestMethod]
        public void TestMethod1()
        {
            BackpackProblem problem = new BackpackProblem(1, 4);
            int cap = 100;

            Result result = problem.Solve(cap);
            Assert.IsTrue(result.FinalItems.Count > 0, "Brak wybranych przedmiotów, mimo że są pasujące");

        }

        //Test 2
        //Czy jeśli żaden element nie spełnia oraniczeń to zwrócono puste rozwiązanie
        [TestMethod]
        public void TestMethod2()
        {
            BackpackProblem problem = new BackpackProblem(3, 1);
            int cap = 1;

            Result result = problem.Solve(cap);
            Assert.AreEqual(0, result.FinalItems.Count, "Lista powinna być pusta");

        }

        //Test 3
        //Poprawność wyniku dla konkretnej instancji
        [TestMethod]
        public void TestMethod3()
        {
            BackpackProblem problem = new BackpackProblem(0, 0);
            problem.SetItems(new List<Items>
            {
                new Items(1, 2, 10),
                new Items(2, 4, 4),
                new Items(3, 5, 1),
                new Items(4, 1, 7)
            });
            int cap = 4;

            Result result = problem.Solve(cap);

            CollectionAssert.AreEqual(new List<int> {4, 1},result.FinalItems, "Powinny być takie same");

        }

        //Test 4
        S//Sprawdzenie co gdy pojemność plecaka będzie 0 (capacity = 0)
        [TestMethod]
        public void TestMethod4()
        {
            BackpackProblem problem = new BackpackProblem(5, 4);
            int cap = 0;

            Result result = problem.Solve(cap);
            Assert.AreEqual(0, result.FinalItems.Count, "Lista powinna być pusta");

        }
        //Test 5
        //Sprawdzanie czy suma wag jest <= pojemności plecaka
        [TestMethod]
        public void TestMethod5()
        {
            BackpackProblem problem = new BackpackProblem(5, 6);
            int cap = 25;

            Result result = problem.Solve(cap);
            Assert.IsTrue(result.waga_sum <= cap, "Suma wag większa niż pojemność plecaka");

        }
  
    }
}
