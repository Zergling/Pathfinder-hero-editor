using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIButton : MonoBehaviour, IPointerClickHandler, IPointerUpHandler, IPointerDownHandler
{
	public void OnPointerClick(PointerEventData eventData)
	{
		Debug.Log(gameObject.name + " OnPointerClick");
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		Debug.Log(gameObject.name + " OnPointerUp");
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log(gameObject.name + " OnPointerDown");
	}
}
