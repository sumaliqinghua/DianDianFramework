using FrameworkDesign.Framework;
namespace FrameworkDesign.Example.Scripts
{
    public struct KillEnemyCommand : ICommand
    {
        public void Execute()
        {
            PointGame.Get<GameModel>().KillCount.Value++;
            if (PointGame.Get<GameModel>().KillCount.Value == 9)
            {
                GamePassEvent.Trigger();
            }
        }
    }
}