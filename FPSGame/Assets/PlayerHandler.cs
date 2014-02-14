using UnityEngine;
using System.Collections;

public class PlayerHandler : MonoBehaviour {

	public float health;
	public float ammo;

	// Use this for initialization
	void Start () {
		health = 100.0f;
		ammo = 31;
	}
	
	// Update is called once per frame
	void Update () {
		print ("HEALTH = " + this.health);
	}
}
