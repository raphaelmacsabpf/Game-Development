using UnityEngine;
using System.Collections;

public class FPS : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "FPS: "+ 1.0f/Time.deltaTime;
	}
}
