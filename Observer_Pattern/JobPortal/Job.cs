using System;

namespace JobPortal
{
    public class Job
    {
        public string Description { get; set; }
        public Job(string description)
        {
            Description = description;
        }
    }
}