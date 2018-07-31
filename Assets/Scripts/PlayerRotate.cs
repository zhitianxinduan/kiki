using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour {
    float xSpeed = 150.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
        {
           if( Input.touchCount == 1)
            {
                if(Input.GetTouch(0).phase==TouchPhase.Moved)
                {
					transform.Rotate(transform.up * Input.GetAxis("Mouse X") * -xSpeed * Time.deltaTime,Space.Self；);
                }
            }
        }
	}
}
