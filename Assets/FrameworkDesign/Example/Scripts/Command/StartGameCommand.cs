using FrameworkDesign.Framework;

namespace FrameworkDesign.Example.Scripts
{
    public struct StartGameCommand : ICommand
    {
        public void Execute()
        {
            GameStartEvent.Trigger();
        }
    }
    
}