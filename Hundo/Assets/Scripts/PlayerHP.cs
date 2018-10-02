using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {

    public GameObject player;
    public Text Health;

	// Use this for initialization
	void Start () {       
	}
	
	// Update is called once per frame
	void Update () {
        Health.text = player.GetComponent<Damageable>().HP.ToString("0");
	}
}
