using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Damageable {

	protected override void onDamaged(float damage) {
		HP -= damage;
	}

	protected override void onDestroyed() {
		Destroy(this.gameObject);
	}
}
