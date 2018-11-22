using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSystem : MonoBehaviour {
    public float speed = 0.1f;
    public float force = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
        Vector3 dir = Vector3.zero;
        
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        
        GetComponent<Rigidbody2D>().AddForce(dir * force);

        /* Touch
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
                Debug.Log("foo");
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
            }
        */
    }
}
