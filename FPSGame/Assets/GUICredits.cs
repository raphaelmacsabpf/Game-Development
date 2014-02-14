using UnityEngine;
using System.Collections;

public class GUICredits : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		if(GUI.Button(new Rect(20,40,80,20), "Voltar")) {
			Application.LoadLevel("Scene2");
		}
	}
}
