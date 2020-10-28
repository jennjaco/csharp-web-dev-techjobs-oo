using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public Job(Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this("No Data", employerName, employerLocation, jobType, jobCoreCompetency) { }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (Name == "")
            {
                Name = "Data not available.";
            }
            else if (String.IsNullOrEmpty(EmployerName.Value))
            {
                EmployerName.Value = "Data not available.";
            }
            else if (EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data not available.";
            }
            else if (JobType.Value == null)
            {
                JobType.Value = "Data not available.";
            }
            else if (JobCoreCompetency.Value == null)
            {
                JobCoreCompetency.Value = "Data not available.";
            }
            return "ID: " + Id + "\n" + "Name: " + Name + "\n" + "Employer: " + EmployerName + "\n" + "Location: " + EmployerLocation + "\n" + "Position Type: " + JobType + "\n" + "Core Competency: " + JobCoreCompetency + "\n";

        }
    }
}