using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollow : MonoBehaviour {

	public float Speed;
	public GameObject Target;

	public void FixedUpdate() {
		transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Speed * Time.deltaTime);
	}
}
