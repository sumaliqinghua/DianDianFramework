using System;

namespace FrameworkDesign.Framework
{
    
public class Event<T> where T:Event<T>//ălă
{

    private static Action mOnEventTrigger;

    public static void Register(Action onEvent)
    {
        mOnEventTrigger += onEvent;
    }
    public static void UnRegister(Action onEvent)
    {
        mOnEventTrigger -= onEvent;
    }

    public static void Trigger()
    {
        mOnEventTrigger?.Invoke();//ălă
    }
    }

}
