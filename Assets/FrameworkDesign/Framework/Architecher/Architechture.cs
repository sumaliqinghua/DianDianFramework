using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Framework
{
    public abstract class Architechture<T> where T : Architechture<T>,new()
    {
        private IOCContainer mContainer = null;
        private static T architechture = null;//S:这儿用T是因为T已经限制继承自Architechture<T>了，是子类

        static void MakeSureContainer()
        {
            if (architechture == null)
            {
                architechture = new T();
                architechture.Init();
            }
        }

        protected abstract void Init();

        public void Register<T>(T instance)
        {
            MakeSureContainer();
            architechture.mContainer.Register<T>(instance);
        }
        public static T Get<T>() where T : class
        {
            MakeSureContainer();
            return architechture.mContainer.Get<T>();
        }
    }
}