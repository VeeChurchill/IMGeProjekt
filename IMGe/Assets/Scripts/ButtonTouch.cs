using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonTouch : MonoBehaviour, IPointerDownHandler{

    private Image button;

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		var gO= GameObject.Find("Button");
        button = gO.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}




    public void Accelerate()
    {

    }

    public void SlowDown()
    {

    }
}
