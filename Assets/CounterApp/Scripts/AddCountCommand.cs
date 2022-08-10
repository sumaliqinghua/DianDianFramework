using FrameworkDesign.Framework;

namespace CounterApp
{
    public struct AddCountCommand : ICommand
    {
        public void Execute()
        {
            CounterModel.Instance.Count.Value++;
        }
    }
}