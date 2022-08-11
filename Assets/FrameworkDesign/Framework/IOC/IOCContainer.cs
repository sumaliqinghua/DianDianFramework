using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign
{
    
    public class IOCContainer
    {
        public Dictionary<Type,object> mInstances = new Dictionary<Type, object>();
       
        public void Register<T>(T instance)
        {
            var key = typeof(T);
            if (mInstances.ContainsKey(key))
            {
                mInstances[key] = instance;
            }
            else
            {
                mInstances.Add(key,instance);
            }
        }
        
        public T Get<T>() where T : class
        {
            var key = typeof(T);
            if (mInstances.TryGetValue(key, out var retObj))
            {
                return retObj as T;//S:泛型返回的应用案例
            }

            return null;
        }
    }

}
