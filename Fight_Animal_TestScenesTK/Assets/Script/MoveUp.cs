using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {

    public Vector2 speed ;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start ()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.AddForce(speed, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y > 7f)
        {
            Destroy(this.gameObject);
        }
	}
}
