using System;

namespace JobPortal
{
    public class JobSeeker : IJobSeeker
    {
        public string Name { get; set; }
        public JobSeeker(string name)
        {
            Name = name;
        }

        public void update(Job job)
        {
            Console.WriteLine($"Hi {Name}, new job posted: {job.Description}");
        }
    }
}