using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Useable : MonoBehaviour {

	private bool isReady;
	public float Rate;

	public Useable() {
		isReady = true;
	}

	protected abstract void onUse();

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
		onUse();
		yield return new WaitForSeconds(Rate);
		isReady = true;
	}
}
