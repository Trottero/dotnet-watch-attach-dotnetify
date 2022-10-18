using System;
using DotNetify;
using System.Threading;

namespace testdotnetify
{
    public class testdotnetify : BaseVM
    {
        private Timer _timer;
        public string Greetings => "Hello World!";
        public DateTime ServerTime => DateTime.Now;
        private int _count = 0;
        public int Count => _count;
        public testdotnetify()
        {
            _timer = new Timer(state =>
            {
                _count = _count + 2;
                Changed(nameof(ServerTime));
                Changed(nameof(Count));
                PushUpdates();
            }, null, 0, 1000);
        }

        public override void Dispose() => _timer.Dispose();
    }
}