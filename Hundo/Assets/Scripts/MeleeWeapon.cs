using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MeleeWeapon : Useable {

	protected Damageable target;

	protected override void onUse() {
		onAttack();
	}

	protected abstract void onAttack();

	public void Attack(Damageable target) {
		this.target = target;
		Use();
	}
}
