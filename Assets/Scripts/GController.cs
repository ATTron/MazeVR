using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class GController : MonoBehaviour {

	public float speed = 2.0f;
	public bool moveFwd;
	private CharacterController controller;
	private GvrViewer gvrViewer;
	private Transform head;

	private int keyCount;
	private bool keyGot;
	public Text countLeft;
	private Scene scene;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
		gvrViewer = transform.GetChild (0).GetComponent<GvrViewer> ();
		head = Camera.main.transform;
		keyCount = 0;
		scene = SceneManager.GetActiveScene ();
		if (scene.name == "MenuScene") {
			SetKeyText ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			moveFwd = !moveFwd;
		}

		if (moveFwd) {
			Vector3 forward = head.TransformDirection (Vector3.forward);
			controller.SimpleMove (forward * speed);
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Key")) {
			other.gameObject.SetActive (false);
			keyCount += 1;
			keyGot = true;
			SetKeyText ();
		}
		if (scene.name == "MainGame") {
			if (other.gameObject.CompareTag ("Key1")) {
				other.gameObject.SetActive (false);
				keyCount += 1;
				keyGot = true;
				SetKeyText ();
			}
			if (other.gameObject.CompareTag ("Key2")) {
				other.gameObject.SetActive (false);
				keyCount += 1;
				keyGot = true;
				SetKeyText ();
			}
		}
		//Destroy (other.gameObject);
	}

	void SetKeyText(){
		if (scene.name == "MenuScene") {
			countLeft.text = "Collect key and enter the door to begin!";
		} else {
			//countLeft.text = "Keys: " + keyCount.ToString() + " / 2";	
		}
	}
		
}
