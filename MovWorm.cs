using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovWorm : MonoBehaviour
{
    public float speed;
	
    void Start(){
			InvokeRepeating ("ChangeDir", 0, 0.5f);
    }
	private Vector2 Randir (){
		int r = Random.Range(-1,2);
		return (Random.value < 0.5) ? new Vector2(r,0) : new Vector2(0,r);
		
	}
	private bool IsValid(Vector2 dir){
		Vector2 pos = transform.position;
		RaycastHit2D hit = Physics2D.Linecast (pos + dir, pos);
		return (hit.collider.gameObject == gameObject);
	}
	
	private void ChangeDir(){
		Vector2 dir = Randir ();
		if (IsValid(dir)){
			GetComponent<Rigidbody2D> ().velocity = dir * speed;
			GetComponent<Animator> ().SetInteger("x", (int)dir.x);
			GetComponent<Animator> ().SetInteger("y", (int)dir.y);
		}
	}
	
}
