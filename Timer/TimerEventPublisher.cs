﻿namespace Timer
{
    using System;
    using System.Timers;
    
    /// <summary>
    /// Publisher of a time-based event.
    /// </summary>
    public class TimerEventPublisher
    {
        /// <summary>
        /// Timer that invokes event after given delay.
        /// </summary>
        private readonly Timer _timer;

        /// <summary>
        /// Event which invokes when time delay ends.
        /// </summary>
        public event EventHandler<TimeEndEventArgs> TimeEnd; 
        
        /// <summary>
        /// Initializes instance of Timer class.
        /// </summary>
        /// <param name="delay">
        /// Delay before event happening in seconds.
        /// </param>
        public TimerEventPublisher(int delay)
        {
            const int MILLISECOND_PER_SECOND = 1000;
            this._timer = new Timer(MILLISECOND_PER_SECOND * delay) { AutoReset = false };
            this._timer.Elapsed += 
                (sender, args) => OnTimeEnd(new TimeEndEventArgs());
        }

        /// <summary>
        /// Starts timers.
        /// </summary>
        public void StartTimer() => this._timer.Start();

        /// <summary>
        /// Invokes TimeEnd event.
        /// </summary>
        /// <param name="args">
        /// TimeEnd handlers arguments.
        /// </param>
        protected virtual void OnTimeEnd(TimeEndEventArgs args)
        {
            this.TimeEnd?.Invoke(this, args);
        }
    }
}