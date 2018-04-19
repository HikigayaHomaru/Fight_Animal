using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour {

    public Vector2 speed = new Vector2 (0f,10f);
    private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
        speed = new Vector2(Random.Range(11f, 6f),0f);
        rb=this.GetComponent<Rigidbody2D>();
        rb.AddForce(speed, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.x > 11f)
        {
            Destroy(this.gameObject);
        }

    }
}
