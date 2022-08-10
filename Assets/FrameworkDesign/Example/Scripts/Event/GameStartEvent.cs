using System;

namespace FrameworkDesign.Example
{
    public static class GameStartEvent//S:静态类
    {
        private static Action mOnEventTrigger;

        public static void Register(Action onEvent)
        {
            mOnEventTrigger += onEvent;//【?】event+event吗 +方法呢
        }

        public static void UnRegister(Action onEvent)
        {
            mOnEventTrigger -= onEvent;
        }

        public static void Trigger()
        {
            mOnEventTrigger.Invoke();
        }
    }
}

