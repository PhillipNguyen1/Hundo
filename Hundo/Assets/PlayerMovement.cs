using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    void Movement() {

        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector2.down * movementSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

    }
}
