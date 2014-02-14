using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.lockCursor = false;
		Screen.showCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,10,100,90), "Menu");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Jogar")) {
			Application.LoadLevel("scene1");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,70,80,20), "Creditos")) {
			Application.LoadLevel("creditos");
		}
	}
}
