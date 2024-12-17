using System;

namespace JobPortal
{
    public class JobPosting : IJobPosting
    {
        private List<IJobSeeker> _seekers = new List<IJobSeeker>();

        public void Attach(IJobSeeker seeker)
        {
            _seekers.Add(seeker);
        }

        public void Detach(IJobSeeker seeker)
        {
            _seekers.Remove(seeker);
        }

        public void Notify(Job job)
        {
            foreach(var seeker in _seekers)
            {
                seeker.update(job);
            }
        }

        public void AddJob(Job job)
        {
            Notify(job);
        }
    }
}