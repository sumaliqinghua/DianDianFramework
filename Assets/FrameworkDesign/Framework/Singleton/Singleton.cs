using System;
using System.Reflection;

namespace FrameworkDesign
{
    
public class Singleton<T> where T : class
{
    public static T Instance
    {
        get
        {
            if (mInstance == null)
            {
                //获取构造函数
                var ctors = typeof(T).GetConstructors(
                    BindingFlags.Instance | BindingFlags.NonPublic);//【?】
                var ctor = Array.Find(ctors, c => c.GetParameters().Length == 0);
                if (ctor ==null)
                {
                    throw new Exception("没找到非公共的构函"+typeof(T));
                }

                mInstance = ctor.Invoke(null) as T;
            }

            return mInstance;
        }
    }
    private static T mInstance;
}
}
