using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2D : MonoBehaviour {

    Rigidbody2D rbody;
    Vector2 velocity;

	void Start () {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * 10;
	}

    void FixedUpdate()
    {
        rbody.MovePosition(rbody.position + velocity * Time.fixedDeltaTime);
    }
}
