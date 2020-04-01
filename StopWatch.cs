using System;

namespace Exc_one_stopwatch
{
    class StopWatch
    {

        private TimeSpan _duration;
        private DateTime _startOn;
        private bool _started;
        public int Duration
        {
            get { return _duration.Milliseconds; }
        }
        public void Start()
        {
            if (_started) throw new System.InvalidOperationException();
            _startOn = DateTime.Now;
            _started = true;
        }

        public void Stop()
        {
            _duration = DateTime.Now.Subtract(_startOn);
            _started = false;
        }
    }
}
