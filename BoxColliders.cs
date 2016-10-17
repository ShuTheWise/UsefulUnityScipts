using UnityEditor;
using UnityEngine;

public class CreateTreeColliders : EditorWindow
{
    [MenuItem("Window/Box cols")]
    static void Init()
    {
        CreateTreeColliders window = GetWindow<CreateTreeColliders>();
        window.Show();
    }
    void OnGUI()
    {
        //GUILayout.Button()

        EditorGUILayout.LabelField("kurwa");
        if (GUILayout.Button("zrób sie"))
        {
            GameObject[] gameobjs = FindObjectsOfType<GameObject>();
            GameObject lamp = Resources.Load("Spotlight") as GameObject;

            foreach (GameObject gameobj in gameobjs)
            {
                string name = gameobj.name;
                if(name == "Layer:3d luz farola")
                {
                    if(gameobj.transform.childCount == 0)
                    {
                        // Instantiate(lamp, gameobj.transform.position, lamp.transform.rotation, gameobj.transform);
                        
                    }
                }
            }
        }
    }
}
           