// See https://aka.ms/new-console-template for more information




using JobPortal;

public static class Program
{
    static void Main(String[] args)
    {
        IJobPosting jobPosting = new JobPosting();

        IJobSeeker Pranaya = new JobSeeker("Pranaya");
        IJobSeeker Anurag = new JobSeeker("Anurag");
        IJobSeeker Kumar = new JobSeeker("Kumar");
        IJobSeeker Rout = new JobSeeker("Rout");

        jobPosting.Attach(Pranaya);
        jobPosting.Attach(Anurag);
        jobPosting.Attach(Kumar);
        jobPosting.Attach(Rout);

        jobPosting.AddJob(new Job("Software Developer at Google"));

        jobPosting.Detach(Anurag);

        jobPosting.AddJob(new Job("Software Developer at Microsoft"));

        Console.ReadLine();
    }
}
