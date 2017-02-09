using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScreen : MonoBehaviour {

	public Scene sceneName;
	public void GoToScene(string sceneName){
		SceneManager.LoadScene (sceneName);
	}
}
