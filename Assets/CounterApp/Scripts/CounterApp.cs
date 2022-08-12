using FrameworkDesign;
using FrameworkDesign.Framework;

namespace CounterApp
{
    public class CounterApp:Architechture <CounterApp>
    {
        protected override void Init()
        {
            Register(new CounterApp());
        }
    }
}