using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
public class GameControls : MonoBehaviour 
{
	public Transform bullet;
	public Transform realBullet;
	public AudioClip fireSound;
	void Start() {
		Screen.lockCursor = true;
		Screen.showCursor = false;
	}
	
	void Update() {
		if(Input.GetMouseButtonDown(0))
		{
			audio.PlayOneShot(fireSound);
			Instantiate(bullet, transform.position,transform.rotation);
			Instantiate(realBullet, transform.position,transform.rotation);
		}
	}
}
