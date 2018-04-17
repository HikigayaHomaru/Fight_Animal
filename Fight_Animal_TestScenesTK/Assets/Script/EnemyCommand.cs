using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCommand : MonoBehaviour {

    public GameObject E;

    private Vector3 EL = new Vector3(-2.4f, 7f, -2f);
    private Vector3 EM = new Vector3(0f, 7f, -2f);
    private Vector3 ER = new Vector3(2.4f, 7f, -2f);

    // Use this for initialization
    void Start ()
    {
        Invoke("MakeE", Random.Range(0.5f, 3f));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void MakeE()
    {
        Invoke("EL"+Random.Range(1,3), Random.Range(0.5f, 3f));
    }

    void EL1()
    {
        Instantiate(E, EL, Quaternion.identity);
        Invoke("MakeE", Random.Range(0.5f, 3f));
    }

    void EL2()
    {
        Instantiate(E, EM, Quaternion.identity);
        Invoke("MakeE", Random.Range(0.5f, 3f));
    }

    void EL3()
    {
        Instantiate(E, ER, Quaternion.identity);
        Invoke("MakeE", Random.Range(0.5f, 3f));
    }

}
