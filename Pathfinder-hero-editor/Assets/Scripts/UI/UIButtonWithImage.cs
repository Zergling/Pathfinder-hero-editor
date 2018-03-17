using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonWithImage : UIButton 
{
	[SerializeField] private Image _image;
	[SerializeField] private Color _clickedColor;
	[SerializeField] private Color _simpleColor;

	public override void OnPointerDownProcess()
	{
		_image.color = _clickedColor;
	}

	public override void OnPointerUpOrExitProcess()
	{
		_image.color = _simpleColor;
	}
}
