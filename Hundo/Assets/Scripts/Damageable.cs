using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Damageable : MonoBehaviour {

	public enum State { ACTIVE, DESTROYED };

	public float HP;
	public State CurrentState;

	protected abstract void onDamaged(float damage);
	
	protected abstract void onDestroyed();

	public void Hit(float damage) {
		if (CurrentState == State.ACTIVE) {
			onDamaged(damage);

			if (HP <= 0.0f) {
				onDestroyed();
				CurrentState = State.DESTROYED;
			}
		}
	}
}
