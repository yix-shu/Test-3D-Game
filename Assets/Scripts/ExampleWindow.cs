using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{
    //string myString = "Hello, World!"; //the default text for the "myString" TextField
    Color color;

    [MenuItem("Window/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<ExampleWindow>("Colorizer");
    }
    void OnGUI()
    {
        GUILayout.Label("Color your active game object(s).", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);
        if (GUILayout.Button("Colorize"))
        {
            foreach (GameObject go in Selection.gameObjects)
            {
                Renderer r = go.GetComponent<Renderer>();
                if (r != null)
                {
                    r.sharedMaterial.color = color;
                }
            }
        }
    }
}
