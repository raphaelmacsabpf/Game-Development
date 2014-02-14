using UnityEngine;
using System.Collections;

public class HudScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Ammo: " + GameObject.Find ("GameHandler").GetComponent<StaticsOfGame> ().nonStaticMainPlayer.transform.GetComponent<PlayerHandler> ().ammo;
	}
}
