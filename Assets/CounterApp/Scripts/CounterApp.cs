using FrameworkDesign;

namespace CounterApp
{
    public class CounterApp
    {
        private static IOCContainer mContainer = null;//S:存单例的字典

        static void MakeSureContainer()
        {
            if (mContainer == null)
            {
                mContainer = new IOCContainer();
            }
        }

        private static void Init()
        {
            mContainer.Register(new CounterModel());//【?】是这个项目的所有单例都在这儿？
        }

        public static T Get<T>() where T : class
        {
            MakeSureContainer();
            return mContainer.Get<T>();
        }
    }
}