using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIButton : Button, IPointerDownHandler, IPointerUpHandler
{
	[SerializeField] private GameObject _disabled;
	[SerializeField] private GameObject _enabled;
	[SerializeField] private GameObject _pressed;

	protected override void DoStateTransition(SelectionState state, bool instant)
	{
		_disabled.SetActive(state == SelectionState.Disabled);
		_enabled.SetActive(state == SelectionState.Normal || state == SelectionState.Highlighted);
		_pressed.SetActive(state == SelectionState.Pressed);
	}
}
