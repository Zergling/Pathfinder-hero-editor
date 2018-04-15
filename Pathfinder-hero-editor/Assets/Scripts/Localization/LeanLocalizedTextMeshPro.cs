using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Localization;
using TMPro;

[ExecuteInEditMode]
public class LeanLocalizedTextMeshPro : LeanLocalizedBehaviour 
{
	public override void UpdateTranslation(LeanTranslation translation)
	{
		if (translation == null)
			return;
		
		TMP_Text text = GetComponent<TMP_Text>();
		if (text == null)
			return;
		
		text.text = translation.Text;
	}
}
