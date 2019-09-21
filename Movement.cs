using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed = 6;

    void FixedUpdate ()
    {
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
		
		GetComponent<Rigidbody2D>().velocity = new Vector2 (h, v) *  speed;
		
		GetComponent<Animator> ().SetInteger ("x", (int)h);
		GetComponent<Animator>( ).SetInteger ("y", (int)v);
        
    }
}
