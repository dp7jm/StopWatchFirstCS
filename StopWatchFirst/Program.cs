using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchFirst
{
    class StopWatch
    {
        private TimeSpan _timeSpan = new TimeSpan();
        private DateTime _startTime = new DateTime();
        private bool _counting = false;
        public void Start()
        {
            if (!_counting)
            {
                throw new InvalidOperationException("watch is working");
            }
            this._startTime = DateTime.Now;

        }
        public void Stop()
        {
            this._timeSpan = this._startTime - DateTime.Now;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
