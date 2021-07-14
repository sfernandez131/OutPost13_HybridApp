using System;

namespace OutPost13_HybridApp
{
    internal class CounterState
    {
        public int CurrentCount { get; private set; }

        public void IncrementCount()
        {
            CurrentCount++;
            StateChanged?.Invoke();
        }

        public event Action StateChanged;
    }
}
