using FrameworkDesign.Example;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GamePassEvent.Register(OnGamePass);
    }

    void OnGamePass()
    {
        transform.Find("Canvas/GamePassPanel").gameObject.SetActive(true);
    }
    void OnDestroy()
    {
        GamePassEvent.UnRegister(OnGamePass);
    }
}
