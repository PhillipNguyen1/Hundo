using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Damageable : MonoBehaviour {

	public enum Status { ACTIVE, DESTROYED };

	public float HP;
	public Status status;

	protected abstract void OnHit(float damage);
	
	protected abstract void OnDestroyed();

	public void Hit(float damage) {
		if (status == Status.ACTIVE) {
			OnHit(damage);

			if (HP <= 0.0f) {
				OnDestroyed();
				status = Status.DESTROYED;
			}
		}
	}
}
