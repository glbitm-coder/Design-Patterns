using System;

namespace JobPortal
{
    public interface IJobPosting
    {
        void Attach(IJobSeeker seeker);
        void Detach(IJobSeeker seeker);
        void Notify(Job job);
        void AddJob(Job job);
    }
}