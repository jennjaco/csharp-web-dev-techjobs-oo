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
            Job jobD = new Job("SAME", new Employer("SAME"), new Location("SAME"), new PositionType("SAME"), new CoreCompetency("SAME"));
            Job jobE = new Job("SAME", new Employer("SAME"), new Location("SAME"), new PositionType("SAME"), new CoreCompetency("SAME"));

            Assert.IsFalse(jobD.Equals(jobE));
        }

        [TestMethod]
        public void TestBlankLine()
        {
            Job jobF = new Job("F", new Employer("F"), new Location("F"), new PositionType("F"), new CoreCompetency("F"));
            Assert.AreEqual(jobF.ToString(), "ID: " + jobF.Id + "\n" + "Name: " + jobF.Name + "\n" + "Employer: " + jobF.EmployerName + "\n" + "Location: " + jobF.EmployerLocation + "\n" + "Position Type: " + jobF.JobType + "\n" + "Core Competency: " + jobF.JobCoreCompetency + "\n");
        }

        [TestMethod]
        public void TestLabel()
        {
            Job jobF = new Job("F", new Employer("F"), new Location("F"), new PositionType("F"), new CoreCompetency("F"));
            Assert.AreEqual(jobF.ToString(), "ID: " + jobF.Id + "\n" + "Name: " + jobF.Name + "\n" + "Employer: " + jobF.EmployerName + "\n" + "Location: " + jobF.EmployerLocation + "\n" + "Position Type: " + jobF.JobType + "\n" + "Core Competency: " + jobF.JobCoreCompetency + "\n");

        }

        [TestMethod]
        public void TestEmpty()
        {
            Job jobF = new Job("F", new Employer(), new Location("F"), new PositionType("F"), new CoreCompetency("F"));
            Assert.AreEqual(jobF.ToString(), "ID: " + jobF.Id + "\n" + "Name: " + jobF.Name + "\n" + "Employer: " + "Data not available." + "\n" + "Location: " + jobF.EmployerLocation + "\n" + "Position Type: " + jobF.JobType + "\n" + "Core Competency: " + jobF.JobCoreCompetency + "\n");
        }
    }
}