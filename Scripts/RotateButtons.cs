using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateButtons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject Cube;
	//Direction : True is Right, False is Left
    public bool Direction;
    private bool Clicked;
    // Use this for initialization
    void Start () {
        Clicked = false;
	}

    // Update is called once per frame
    void Update()
    {
        if (Clicked)
        {
            if (Direction)
                Cube.transform.Rotate(0, -1, 0);
            else
                Cube.transform.Rotate(0, 1, 0);
        }
    }

        public void OnPointerDown(PointerEventData eventData)
        {
            Clicked = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            Clicked = false;
        }

}