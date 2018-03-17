using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIButtonWithText : UIButton
{
	[SerializeField] private TMP_Text _text;
	[SerializeField] private Material _simpleMaterial;
	[SerializeField] private Material _clickMaterial;

	public override void OnPointerDownProcess()
	{
		_text.fontMaterial = _clickMaterial;
	}

	public override void OnPointerUpOrExitProcess()
	{
		_text.fontMaterial = _simpleMaterial;
	}
}
