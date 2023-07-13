using Fluxor;

namespace FluxorWasm.State.Counter
{
    [FeatureState]
    public class CounterState
    {
        public int ClickCount { get; }

        public CounterState()
        {
            ClickCount = 0;
        }
        public CounterState(int clickCount)
        {
            ClickCount = clickCount;
        }
    }

    
}
