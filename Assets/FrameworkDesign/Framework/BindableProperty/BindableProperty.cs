using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign
{
    
public class BindableProperty<T> where T:IEquatable<T>//【?】IEquatable
{
    private T mValue;

    public T Value
    {
        get => mValue;
        set
        {
            if (!mValue.Equals(value))
            {
                mValue = value;
                OnValueChanged?.Invoke(value);
            }
        }
    }

    public Action<T> OnValueChanged;//S:委托在这里调用；外部把方法传给委托
}
}
