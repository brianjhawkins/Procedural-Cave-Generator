using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3D : MonoBehaviour {

    Rigidbody rbody;
    Vector3 velocity;

	void Start () {
        rbody = GetComponent<Rigidbody>();
	}
	
	void Update () {
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * 10;
	}

    void FixedUpdate()
    {
        rbody.MovePosition(rbody.position + velocity * Time.fixedDeltaTime);
    }
}
