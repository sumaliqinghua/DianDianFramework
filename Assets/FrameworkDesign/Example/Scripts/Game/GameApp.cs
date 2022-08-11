using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Example.Scripts
{ 
   public class GameApp 
   {
   // private static Dictionary<Type, object> mContainer;
   private static IOCContainer mContainer = null;

   static void MakeSureContainer()
   {
      if (mContainer == null)
      {
         mContainer = new IOCContainer();
         Init();
      }
   }
   static void Init()
   {
      mContainer.Register(new GameModel());
   }

   public static T Get<T>() where T :class
   {
      MakeSureContainer();
      return mContainer.Get<T>();
   }
}
}
