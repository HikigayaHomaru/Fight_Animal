using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyCommand : MonoBehaviour {

    public GameObject Y;
    public GameObject B;
    public GameObject R;
    public GameObject G;

    private Vector3 YP = new Vector3(-1.2f, -7f,-2f);
    private Vector3 BP = new Vector3(1.2f, -7f, -2f);
    private Vector3 RP = new Vector3(3.6f, -7f, -2f);
    private Vector3 GP = new Vector3(-3.6f, -7f, -2f);
    
    // Use this for initialization
    void Start () {

            Invoke("MakeY", Random.Range(1f, 2f));
            Invoke("MakeB", Random.Range(2f, 4f));
            Invoke("MakeR", Random.Range(3f, 5f));
            Invoke("MakeG", Random.Range(0f, 5f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void MakeY()
    {
        Instantiate(Y, YP, Quaternion.identity);
        Invoke("MakeY", Random.Range(2f, 5f));
    }

    void MakeB()
    {
        Instantiate(B, BP, Quaternion.identity);
        Invoke("MakeB", Random.Range(2f, 5f));
    }

    void MakeR()
    {
        Instantiate(R, RP, Quaternion.identity);
        Invoke("MakeR", Random.Range(2f, 5f));
    }

    void MakeG()
    {
        Instantiate(G, GP, Quaternion.identity);
        Invoke("MakeG", Random.Range(2f, 5f));
    }

}
