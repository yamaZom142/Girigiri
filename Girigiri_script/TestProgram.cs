using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProgram : MonoBehaviour {
    // Use this for initialization
    bool fuck = true;
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(fuck == true)
            transform.position += new Vector3(0.3f,0,0);

           Debug.Log("出てる");
           StartCoroutine(Stopper());
    }

    private IEnumerator Stopper()
    {
        fuck = false;
        Debug.Log("1");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("2");
        fuck = true;
        yield return new WaitForSeconds(2.0f);
        Debug.Log("3");
        fuck = false;
    }
}
