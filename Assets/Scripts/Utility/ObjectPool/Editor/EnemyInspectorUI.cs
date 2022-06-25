using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(ObjectPoolEnemy))]

public class EnemyInspectorUI : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		ObjectPoolEnemy myScript = (ObjectPoolEnemy)target;

		if (GUILayout.Button("Pop Object"))
		{
			myScript.testObjectPop();

		}
		else if(GUILayout.Button("Return Object"))
        {
			myScript.testObjectReturn();
        }

	}

}