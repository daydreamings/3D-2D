using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CustomButton : MonoBehaviour, IPointerClickHandler
{
    public delegate void ButtonClickedEvent();
    public event ButtonClickedEvent OnButtonClicked;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (OnButtonClicked != null)
        {
            OnButtonClicked.Invoke();
        }
    }
}

