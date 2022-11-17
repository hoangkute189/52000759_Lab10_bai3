using UnitTestConsole;

namespace TestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1,false,2,3862.5)]
        [DataRow(2, false, 2, 5725)]
        [DataRow(2, true, 3, 6687.75)]
        [DataRow(3, true, 4, 9531.625)]
        public void TestMethodOfTeacher(double factor, bool union, int seniority, double salary)
        {
            Teacher teacher = new Teacher();
            teacher.Factor = factor;
            teacher.UnionMember = union;
            teacher.Seniority = seniority;
            Assert.AreEqual(salary, teacher.GetSalary());

        }

        [TestMethod]
        [DataRow(1, 1, 1, 11375.1)]
        [DataRow(2, 3, 1, 32650.2)]
        [DataRow(2, 3, 3, 151450.2)]
        [DataRow(3, 4, 3, 202425.3)]
        public void TestMethodOfResearch(double factor, int numOfPaper, int paperRank, double salary)
        {
            Researcher researcher = new Researcher();
            researcher.Factor = factor;
            researcher.NumOfPaper = numOfPaper;
            researcher.PaperRank = paperRank;
            Assert.AreEqual(salary, researcher.GetSalary());

        }
    }
}