using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour {

    public Vector2 speed = new Vector2 (-10f,0f);
    private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
        speed = new Vector2(0f,Random.Range(-15f, -5f));
        rb=this.GetComponent<Rigidbody2D>();
        rb.AddForce(speed, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y < -7f)
        {
            Destroy(this.gameObject);
        }

    }
}
