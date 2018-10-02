using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class SimpleMovement : MonoBehaviour {

	public float Speed;
	private Vector2 direction;
	private Rigidbody2D rigidbody;

	public void Start() {
		rigidbody = GetComponent<Rigidbody2D>();
	}

	public void Update() {
		direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}

	public void FixedUpdate() {
		rigidbody.velocity = new Vector3(direction.x, direction.y, 0.0f) * Speed;
	}
}
