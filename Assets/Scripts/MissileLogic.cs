using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLogic : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {        
        gameObject.transform.Translate(Vector3.up * -1.0f);              
    }
}
