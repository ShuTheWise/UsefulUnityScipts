using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;
using System.IO;

public class DeleteComponent : EditorWindow
{
    [MenuItem("Window/DeteleComponent")]
    static void Init()
    {
        DeleteComponent window = GetWindow<DeleteComponent>();
        window.Show();
    }
    void OnGUI()
    {
        //GUILayout.Button()
        EditorGUILayout.LabelField("Delete Component");
        if (GUILayout.Button("Detele it"))
        {
            
        }
    }
}