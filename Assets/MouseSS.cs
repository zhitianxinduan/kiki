using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSS : MonoBehaviour {
    Rigidbody rigidbody;
    bool isOpen = false;
	// Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isOpen)
        {
            rigidbody.isKinematic = false;
        }

    }
    private void OnMouseDown()
    {
        rigidbody.isKinematic = false;
        isOpen = true;
    }

    private void OnMouseUp()
    {
       
        isOpen = false;
        rigidbody.isKinematic = true;
    }
}
