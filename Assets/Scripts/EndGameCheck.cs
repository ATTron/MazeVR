using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCheck : MonoBehaviour {
	public bool hasKey1;
	public bool hasKey2;
	public bool hasBoth;
	private GameObject key1;
	private GameObject key2;
	private GameObject gTrigger;
	private BoxCollider bcGate;

	// Use this for initialization
	void Start () {
		hasKey1 = false;
		hasKey2 = false;
		hasBoth = false;

		key1 = GameObject.Find ("Key1");
		key2 = GameObject.Find ("Key2");

		gTrigger = GameObject.Find ("GateTrigger");

		bcGate = gTrigger.GetComponent<BoxCollider> ();
		bcGate.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		hasKey1 = !key1.activeInHierarchy;
		hasKey2 = !key2.activeInHierarchy;

		if (hasKey1 && hasKey2) {
			hasKey1 = true;
			hasKey2 = true;
			hasBoth = true;
			bcGate.enabled = true;
		}
	}
}
