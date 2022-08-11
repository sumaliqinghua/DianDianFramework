using FrameworkDesign.Framework;
namespace FrameworkDesign.Example.Scripts
{
    public struct KillEnemyCommand : ICommand
    {
        public void Execute()
        {
            GameApp.Get<GameModel>().KillCount.Value++;
            if (GameApp.Get<GameModel>().KillCount.Value == 9)
            {
                GamePassEvent.Trigger();
            }
        }
    }
}