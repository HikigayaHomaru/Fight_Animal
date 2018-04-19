using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yidong4 : MonoBehaviour
{

    private float x = -2.5f;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (x > 10.6f)
        { x = -10.6f; }



        x = x + 0.13f;
        this.transform.position = new Vector3(x, -3.5f, 0);


    }
}
