using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {

	private bool isReady;
	public float Rate;

	public Weapon() {
		isReady = true;
	}

	protected abstract void OnUse();

	public bool Use() {
		if (isReady) {
			StartCoroutine(exec());
			return true;
		} else {
			return false;
		}
	}

	private IEnumerator exec() {
		isReady = false;
		OnUse();
		yield return new WaitForSeconds(Rate);
		isReady = true;
	}
}
