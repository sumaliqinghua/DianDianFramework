using FrameworkDesign.Example.Scripts;
using UnityEngine;
using UnityEngine.UI;

namespace FrameworkDesign.Example
{
    
public class GameStartPanel : MonoBehaviour
{
    void Start()
    {
        transform.Find("BtnGameStart").GetComponent<Button>().onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            new StartGameCommand().Execute();
        });
        
    }
}
}
