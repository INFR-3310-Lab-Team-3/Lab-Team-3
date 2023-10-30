using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

public class MaterialChanger : EditorWindow
{
    Material mat;

    [MenuItem("Window/ObjectSelector")]
    public static void EnableWindow()
    {
        GetWindow<MaterialChanger>("ObjectSelector");
    }

    private void OnGUI()
    {
        GUILayout.Label("Change Current Object Material\n", EditorStyles.boldLabel);

        mat = (Material)EditorGUILayout.ObjectField(mat, typeof(Material), true);

        if (GUILayout.Button("Assign"))
        {
            foreach (GameObject obj in Selection.gameObjects){
                obj.GetComponent<Renderer>().material = mat;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
