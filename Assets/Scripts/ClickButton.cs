using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData pointerEventDada)
    {
        Application.LoadLevel(1);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
