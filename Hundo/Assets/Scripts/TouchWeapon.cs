using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Collider2D))]
public class TouchWeapon : MeleeWeapon {

	public float Damage;

	protected override void onAttack() {
		target.Hit(Damage);
	}

	public void OnTriggerStay2D(Collider2D col) {
		Damageable damageable = col.gameObject.GetComponent<Damageable>();
		if (damageable != null) {
			Attack(damageable);
		}
	}
}