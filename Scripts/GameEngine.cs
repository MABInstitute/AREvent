using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour {

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor(GetTouchedObject());
    }

    public GameObject GetTouchedObject()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                string name = hit.transform.name;
                Debug.Log(name);
                return GameObject.Find(name);

            }
        }
        return null;
    }

    private void ChangeColor(GameObject o)
    {
        if (o != null)
        {
            Renderer renderer = o.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Random.ColorHSV());
        }
    }
}

