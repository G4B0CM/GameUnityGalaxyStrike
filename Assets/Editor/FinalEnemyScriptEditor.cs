using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FinalEnemyScript))]
public class FinalEnemyScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Dibuja todo automáticamente, incluyendo los campos heredados
        DrawDefaultInspector();
    }
}