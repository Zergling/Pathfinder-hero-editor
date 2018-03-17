using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIButton : Button, IPointerDownHandler, IPointerUpHandler
{
	public void OnPointerDown(PointerEventData eventData)
	{
		base.OnPointerDown(eventData);

		if (!interactable)
			return;
		
		OnPointerDownProcess();
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		base.OnPointerUp(eventData);

		if (!interactable)
			return;
		
		OnPointerUpOrExitProcess();
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
		base.OnPointerExit(eventData);

		if (!interactable)
			return;
		
		OnPointerUpOrExitProcess();
	}

	public virtual void OnPointerDownProcess()
	{
	}

	public virtual void OnPointerUpOrExitProcess()
	{
	}
}
