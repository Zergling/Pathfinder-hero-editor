using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Lean.Localization;

[CustomEditor(typeof(LocalizationConfigurator))]
public class LocalizationConfiguratorEditor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		if (GUILayout.Button("TEST UPDATE"))
			TestUpdate();
	}

	private void TestUpdate()
	{
		LocalizationConfigurator configurator = (LocalizationConfigurator)target;

		string[] lines = File.ReadAllLines(string.Format("{0}/test.csv", Application.dataPath));

		string[] languages = lines[0].Split(',');
		for (int i = 1; i < languages.Length; i++)
			configurator.AddLanguage(languages[i]);

		for (int i = 1; i < lines.Length; i++) 
		{
			string[] lineInfo = lines[i].Split(',');
			LeanPhrase phrase = configurator.AddPhrase(lineInfo[0]);
			for (int j = 1; j < languages.Length; j++) 
			{
				LeanTranslation translation = phrase.AddTranslation(languages[j]);
				translation.Text = lineInfo[j];
			}
		}
	}
}
