using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign
{
    
    public class IOCContainer
    {
        public Dictionary<Type,object> mInstances = new Dictionary<Type, object>();
        //【?】type是一种类typeof出来的都是Type类吗//【?】怎么反射会真实类的
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="instance"></param>
        /// <typeparam name="T"></typeparam>
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
        /// <summary>
        /// 获取
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Get<T>() where T : class
        {
            var key = typeof(T);//【?】啥时候用var
            object retObj;
            if (mInstances.TryGetValue(key, out retObj))
            {
                return retObj as T;//S:泛型返回的应用案例
            }

            return null;
        }
    }

}
