using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheck : MonoBehaviour {
	// Used to check if the player has collected the key to get through the door
	public bool hasKey;
	// Need to get door GameObject
	private GameObject door;
	// Need to get key GameObject
	private GameObject key;
	// Need to get the collider on the door
	private BoxCollider boxCollider;

	void Start () {
		// Finds GameObjects and find collider attached to the door and disabes it
		hasKey = false;
		key = GameObject.Find ("Key");
		door = GameObject.Find ("Door");
		boxCollider = door.GetComponent<BoxCollider>();
		boxCollider.enabled = false;
	}
		
	void Update () {
		// Once the player has collected the key the door collider will be reenabled
		hasKey = !key.activeInHierarchy;
		if (hasKey){
			hasKey = true;
			boxCollider.enabled = true;
		}
	}
}
