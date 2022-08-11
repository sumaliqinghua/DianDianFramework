using System;
using System.Collections;
using System.Collections.Generic;
using CounterApp;
using UnityEditor;
using UnityEngine;

public class EditorCounterApp : EditorWindow
{
    [MenuItem("EditorCounterApp/Open")]
    static void Open()
    {
        var editorCounterApp = GetWindow<EditorCounterApp>();
        editorCounterApp.name = nameof(EditorCounterApp);//【l】nameof
        editorCounterApp.position = new Rect(100,100,400,600);//【?】为啥是pos
        editorCounterApp.Show();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("+"))
        {
            new AddCountCommand().Execute();
        }
        GUILayout.Label(CounterApp.CounterApp.Get<CounterModel>().Count.Value.ToString());
        if (GUILayout.Button("-"))
        {
            new SubCountCommand().Execute();
        }
    }
}
