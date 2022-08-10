using System.Collections;
using System.Collections.Generic;
using FrameworkDesign.Example.Scripts;
using UnityEngine;

namespace FrameworkDesign.Example
{
    public class Enemy : MonoBehaviour
    {
        private void OnMouseDown()
        {
            Destroy(gameObject);
            // KilledOneEnemyEvent.Trigger();
            // GameModel.KillCount.Value++;
            new KillEnemyCommand().Execute();//【?】感觉单语句的还不如上面那种直观
        }
    }
}

