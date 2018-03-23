using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UI;

[CustomEditor(typeof(UIButton))]
public class UIButtonEditor : ButtonEditor 
{
	private SerializedProperty disabled;
	private SerializedProperty enabled;
	private SerializedProperty pressed;

	public override void OnInspectorGUI()
	{
		serializedObject.Update();
		base.OnInspectorGUI();

		disabled = serializedObject.FindProperty("_disabled");
		enabled = serializedObject.FindProperty("_enabled");
		pressed = serializedObject.FindProperty("_pressed");

		EditorGUILayout.PropertyField(disabled, true);
		EditorGUILayout.PropertyField(enabled, true);
		EditorGUILayout.PropertyField(pressed, true);

		serializedObject.ApplyModifiedProperties();
	}
}
