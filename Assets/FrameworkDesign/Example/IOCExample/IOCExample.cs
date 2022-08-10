using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign
{
    
public class IOCExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var container = new IOCContainer();
        container.Register(new BluetoothManager());//S:注册一个实例
        var blutoothManager = container.Get<BluetoothManager>();
        blutoothManager.Connect();
    }
}

public class BluetoothManager
{
    public void Connect()
    {
        Debug.Log("蓝牙连接成功");
    }
}
}
