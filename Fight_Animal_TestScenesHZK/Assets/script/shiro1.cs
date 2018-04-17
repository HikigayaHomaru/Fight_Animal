using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiro1 : MonoBehaviour {

    private float x=-10f;
    private float y;

    // Use this for initialization
    void Start () {
        int z = Random.Range(1, 4);
        switch (z)
        {
            case 1:
                y = 4f;
                break;
            case 2:
                y = 1.5f;
                break;
            case 3:
                y = -1f;
                break;
            case 4:
                y = -3.5f;
                break;

        }
    }
	
	// Update is called once per frame
	void Update () {
        if (x > 10.6f)
        {
            x = -10.6f;

            int z = Random.Range(1, 4);

            switch (z)
            {
                case 1:
                    y = 4f;
                    break;
                case 2:
                    y = 1.5f;
                    break;
                case 3:
                    y = -1f;
                    break;
                case 4:
                    y = -3.5f;
                    break;

            }
        }

        x = x + 0.06f;
        this.transform.position = new Vector3(x, y, 0);
    }
}
