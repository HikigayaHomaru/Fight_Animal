using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yidong : MonoBehaviour {

    private float x=-5;

	// Use this for initialization
	void Start () {
     
       
       
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (x > 10.6f)
        { x = -10.6f; }



        x=x+0.1f;
        this.transform.position = new Vector3(x, 4, 0);

        
    }
}
    