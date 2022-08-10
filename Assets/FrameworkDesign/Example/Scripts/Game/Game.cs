using FrameworkDesign.Example.Scripts;
using UnityEngine;

namespace FrameworkDesign.Example
{
public class Game : MonoBehaviour
{
    void Start()
    {
        GameStartEvent.Register(OnGameStart);
        // KilledOneEnemyEvent.Register(OneEnemyKilled);
        // GameModel.KillCount.OnValueChanged += OneEnemyKilled;
    }

    // private void OneEnemyKilled()
    // {
        // GameModel.KillCount.Value++;
        // if (GameModel.KillCount.Value == 9)
        // {
        //     GamePassEvent.Trigger();
        // }
    // }
    // private void OneEnemyKilled(int killedCount)//【】数据怎么传//S:是执行委托的时候调用这个
    // // 方法，由委托那边传
    // {       
    //     if (killedCount == 9)
    //     {
    //         new PassGameCommand().Execute();
    //     }
    // }


    private void OnGameStart()
    {
        transform.Find("Enemies").gameObject.SetActive(true);
    }

    private void OnDestroy()
    {
        GameStartEvent.UnRegister(OnGameStart);
        // GameModel.KillCount.OnValueChanged += OneEnemyKilled;
    }
}
}
