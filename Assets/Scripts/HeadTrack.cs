using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTrack : MonoBehaviour {

	public GameObject text;
	// Use this for initialization
	void Start () {
		text = GameObject.Find ("Key Count");
		if (text != null) {
			Debug.Log ("FOUND KEY COUNT TEXT");
		}
	}
	
	// Update is called once per frame
	void Update () {
		text.transform.LookAt (Camera.main.transform);
	}
}
