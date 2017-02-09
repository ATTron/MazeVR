using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGates : MonoBehaviour {
	private GameObject leftSide;
	private GameObject rightSide;
	private GameObject gTrigger;
	private EndGameCheck check;
	// Use this for initialization
	void Start () {
		leftSide = GameObject.Find ("LeftLocks");
		rightSide = GameObject.Find ("RightLocks");
		gTrigger = GameObject.Find ("GateTrigger");
		check = gTrigger.GetComponent<EndGameCheck> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void openGates () {
		if (check.hasBoth) {
			leftSide.transform.localScale = new Vector3 (0.0f, 1.0f, 0.0f);
			rightSide.transform.localScale = new Vector3 (0.0f, 1.0f, 0.0f);
			gTrigger.transform.localScale = new Vector3 (0.0f, 1.0f, 0.0f);
		}
	}
}
