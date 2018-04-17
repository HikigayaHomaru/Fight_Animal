using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yidong3 : MonoBehaviour
{

    private float x = 2;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (x > 10.6f)
        { x = -10.6f; }



        x = x + 0.18f;
        this.transform.position = new Vector3(x, -1, 0);


    }
}
