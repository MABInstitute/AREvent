using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();

	}

    void Update()
    {
        if (DefaultTrackableEventHandler.CUBE_TRACKED && DefaultTrackableEventHandler.SPHERE_TRACKED)
            transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        else
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }
    void OnTriggerEnter(Collider sphere)
    {
        Debug.Log("Collision");
        if (sphere.gameObject.name == "Sphere (1)")
        {
            Destroy(sphere.gameObject);
        }
    }

    public void OnBlink()
    {
        animator.SetTrigger("Blink");
    }
}
