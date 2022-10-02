using FrameworkDesign.Framework;
namespace FrameworkDesign.Example.Scripts
{
    public struct KillEnemyCommand : ICommand
    {
        public void Execute()
        {
            PointGame.Get<IGameModel>().KillCount.Value++;
            if (PointGame.Get<IGameModel>().KillCount.Value == 9)
            {
                GamePassEvent.Trigger();
            }
        }
    }
}