using UnityEditor;
using UnityEngine;

public class BoxCols : EditorWindow
{
    [MenuItem("Window/Create capsule cols")]
    static void Init()
    {
        BoxCols window = GetWindow<BoxCols>();
        window.Show();
    }
    void OnGUI()
    {
        //GUILayout.Button()

        EditorGUILayout.LabelField("Gen box cols");
        if (GUILayout.Button("do it"))
        {
            GameObject[] gameobjs = FindObjectsOfType<GameObject>();

            foreach (GameObject gameobj in gameobjs)
            {
                if (gameobj.name == "Layer:3d farola004")
                {
                    Debug.Log("found it");
                    
                    if (gameobj.GetComponent<CapsuleCollider>() == null)
                    {
                        CapsuleCollider cc = gameobj.AddComponent<CapsuleCollider>();
                        cc.radius = 0.09f;
                        cc.height = 9f;
                        cc.center = new Vector3(0, -0.55f, 1);
                        cc.direction = 2;
                    }
                    else
                    {
                        CapsuleCollider cc = gameobj.GetComponent<CapsuleCollider>();
                        cc.radius = 0.09f;
                        cc.height = 9f;
                        cc.center = new Vector3(0, -0.55f, 1);
                        cc.direction = 2;
                    }
                }
            }
        }
    }
}