using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job jobA = new Job("A", new Employer("A"), new Location("A"), new PositionType("A"), new CoreCompetency("A"));
            Job jobB = new Job("B", new Employer("B"), new Location("B"), new PositionType("B"), new CoreCompetency("B"));

            Assert.AreEqual(jobA.Id + 1, jobB.Id, .001);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job jobC = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(jobC.Name, "Product tester");
            Assert.AreEqual(jobC.EmployerName.ToString(), "ACME");
            Assert.AreEqual(jobC.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(jobC.JobType.ToString(), "Quality control");
            Assert.AreEqual(jobC.JobCoreCompetency.ToString(), "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job jobD = new Job("B", new Employer("B"), new Location("B"), new PositionType("B"), new CoreCompetency("B"));
            Job jobE = new Job("B", new Employer("B"), new Location("B"), new PositionType("B"), new CoreCompetency("B"));

            Assert.IsFalse(jobD.Equals(jobE));
        }
    }
}
