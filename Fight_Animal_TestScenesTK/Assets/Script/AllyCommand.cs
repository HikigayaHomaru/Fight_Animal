using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyCommand : MonoBehaviour {

    public GameObject Y;
    public GameObject B;
    public GameObject R;
    public GameObject G;

    private Vector3 BP = new Vector3(11f, 3f, -2f);
    private Vector3 YP = new Vector3(11f, 1f,-2f);
    private Vector3 RP = new Vector3(11f, -1f, -2f);
    private Vector3 GP = new Vector3(11f, -3f, -2f);
    
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
        Instantiate(Y, YP, Quaternion.Euler(0f, 0f, 90f));
        Invoke("MakeY", Random.Range(3f, 6f));
    }

    void MakeB()
    {
        Instantiate(B, BP, Quaternion.Euler(0f, 0f, 90f));
        Invoke("MakeB", Random.Range(4f, 7f));
    }

    void MakeR()
    {
        Instantiate(R, RP, Quaternion.Euler(0f, 0f, 90f));
        Invoke("MakeR", Random.Range(2f, 5f));
    }

    void MakeG()
    {
        Instantiate(G, GP, Quaternion.Euler(0f, 0f, 90f));
        Invoke("MakeG", Random.Range(1f, 4f));
    }

}
