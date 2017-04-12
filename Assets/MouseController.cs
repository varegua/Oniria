using System;
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
     , IPointerClickHandler
{
    Ray ray;
    RaycastHit[] hits;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
	    {
	        WhatMouseOver();
	    }
	}

    private void WhatMouseOver()
    {
        //Code to be place in a MonoBehaviour with a GraphicRaycaster component
        GraphicRaycaster gr = this.GetComponent<GraphicRaycaster>();
        //Create the PointerEventData with null for the EventSystem
        PointerEventData ped = new PointerEventData(null);
        //Set required parameters, in this case, mouse position
        ped.position = Input.mousePosition;
        //Create list to receive all results
        List<RaycastResult> results = new List<RaycastResult>();
        //Raycast it
        gr.Raycast(ped, results);

        I results[0].module.name

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hits = Physics.RaycastAll(ray, Single.PositiveInfinity);
        if (hits.Length != 0)
        {
            foreach (var raycastHit in hits)
            {
                print(raycastHit.collider.name);
            }
        }
    }

    public static void CanvasMouseOver(object result)
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }
}
