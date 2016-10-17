using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;
using System.IO;

public class DeleteLODs : EditorWindow
{
    [MenuItem("Window/DeteleLODs")]
    static void Init()
    {
        DeleteLODs window = GetWindow<DeleteLODs>();
        window.Show();
    }
    void OnGUI()
    {
        //GUILayout.Button()
        EditorGUILayout.LabelField("Delete LODs");
        if (GUILayout.Button("Detele all LODs on the scene"))
        {
            LODGroup[] gameObjs = FindObjectsOfType<LODGroup>();

            foreach (LODGroup lod in gameObjs)
            {
                foreach (Transform tran in lod.transform)
                {
                    string name = tran.name;
                    int nameLenght = name.Length;

                    if (name.Substring(nameLenght - 4) != "LOD0")
                    {
                        DestroyImmediate(tran.gameObject);
                        Debug.Log("DEstroy LOD1" + name);
                    }
                }
                DestroyImmediate(lod);
            }
        }
    }
}