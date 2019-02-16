using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Enter");
        if(coll.gameObject.tag =="Enemy")
        Destroy(coll.gameObject);
    }
}
