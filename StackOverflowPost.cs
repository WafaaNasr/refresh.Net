using System;

namespace Exc_one_stopwatch
{
    class StackOverflowPost
    {
        private readonly DateTime _createdAt = DateTime.Now;
        public int Vote { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public void UpVote() => Vote++;
        public void DownVote() => Vote--;
    }
}
