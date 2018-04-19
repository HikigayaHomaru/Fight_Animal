using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCommand : MonoBehaviour {

    public GameObject E;

    private Vector3 E1 = new Vector3(-11f, 3f, -2f);
    private Vector3 E2 = new Vector3(-11f, 1f, -2f);
    private Vector3 E3 = new Vector3(-11f, -1f, -2f);
    private Vector3 E4 = new Vector3(-11f, -3f, -2f);

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
        Invoke("EL"+Random.Range(1,4), Random.Range(0.1f, 1f));
    }

    void EL1()
    {
        Instantiate(E, E1, Quaternion.Euler(0f,0f,-90f));
        Invoke("MakeE", Random.Range(0.5f, 2f));
    }

    void EL2()
    {
        Instantiate(E, E2, Quaternion.Euler(0f, 0f, -90f));
        Invoke("MakeE", Random.Range(0.5f, 2f));
    }

    void EL3()
    {
        Instantiate(E, E3, Quaternion.Euler(0f, 0f, -90f));
        Invoke("MakeE", Random.Range(0.5f, 2f));
    }

    void EL4()
    {
        Instantiate(E, E4, Quaternion.Euler(0f, 0f, -90f));
        Invoke("MakeE", Random.Range(0.5f, 2f));
    }

}
