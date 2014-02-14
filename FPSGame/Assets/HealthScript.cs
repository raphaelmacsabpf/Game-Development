using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float health = GameObject.Find ("GameHandler").GetComponent<StaticsOfGame> ().nonStaticMainPlayer.transform.GetComponent<PlayerHandler> ().health;
		if(health > 0)
			guiText.text = "Health: " + health;
		else
			guiText.text = "Health: 0.00";
		if(health <= 0)
			Application.LoadLevel("Scene2");
	}
}
