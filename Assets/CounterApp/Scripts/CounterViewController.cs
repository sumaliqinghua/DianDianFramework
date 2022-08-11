using System;
using FrameworkDesign;
using FrameworkDesign.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace CounterApp
{
    public class  Fanxing<T>:MonoBehaviour
    {
        public static int A;
        private T a = default(T);

    }
public class CounterViewController : MonoBehaviour
{

    void Start()
    {
        transform.Find("BtnAdd").GetComponent<Button>().onClick.AddListener(() =>
        {
            // CounterModel.Count.Value++;//S:属性
            new AddCountCommand().Execute();
        });
        transform.Find("BtnSub").GetComponent<Button>().onClick.AddListener(() =>
        {
            // AddCountCommand addCountCommand = new AddCountCommand();
            // addCountCommand.Execute();
            new SubCountCommand().Execute();
            // CounterModel.Count.Value--;
            // UpdateView();
        });
        // UpdateView();//S:初始化显示
        CounterApp.Get<CounterModel>().Count.OnValueChanged += OnCountChanged;
        OnCountChanged(CounterApp.Get<CounterModel>().Count.Value);
    }


    void OnCountChanged(int newCount)
    {
        transform.Find("CounterText").GetComponent<Text>().text = newCount.ToString();
    }

    private void OnDestroy()
    {
        CounterApp.Get<CounterModel>().Count.OnValueChanged -= OnCountChanged;
    }
}

public class CounterModel
{
    public BindableProperty<int> Count = new BindableProperty<int>()
    {
        Value = 0//S:初始化
    };
}

// public class OnCountChangedEvent : Event<OnCountChangedEvent>
// {
//     
// }
}
