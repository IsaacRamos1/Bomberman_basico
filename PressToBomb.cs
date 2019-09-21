using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressToBomb : MonoBehaviour
{
    public GameObject bombPrefab;
	
    void Update()
    {	if(Input.GetKeyDown(KeyCode.Space)){
			Vector2 pos = transform.position;
			pos.x = Mathf.Round (pos.x);
			pos.y = Mathf.Round (pos.y);
			Instantiate (bombPrefab, pos, Quaternion.identity);
		
	}
        
    }
}
