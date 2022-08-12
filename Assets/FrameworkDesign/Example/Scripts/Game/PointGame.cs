using FrameworkDesign.Framework;

namespace FrameworkDesign.Example.Scripts
{
    public class PointGame : Architechture<PointGame>
    {
        protected override void Init()
        {
            Register(new GameModel());
        }
    }
}