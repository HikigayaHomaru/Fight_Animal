using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("KillMe",1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void KillMe()
    {
        Destroy(this.gameObject);
    }
}
