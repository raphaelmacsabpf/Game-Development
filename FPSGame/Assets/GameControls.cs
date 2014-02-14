using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
public class GameControls : MonoBehaviour 
{
	public Transform bullet;
	public Transform realBullet;
	public AudioClip fireSound;
	public AudioClip reloadSound;
	public Transform weaponNoZoom;
	public Transform weaponWithZoom;
	public Transform Sight;
	public float ballTime;
	public float reloadingTime;
	public bool isReloading;
	PlayerHandler playerHandler;
	void Start() {
		Screen.lockCursor = true;
		Screen.showCursor = false;
		ballTime = 0.0f;
		playerHandler = GameObject.Find ("GameHandler").GetComponent<StaticsOfGame> ().nonStaticMainPlayer.transform.GetComponent<PlayerHandler>();
	}
	
	void Update() {
		//ballTime = 0.0f;
		if (ballTime >= 0.0f)
		{
			ballTime -= Time.deltaTime;
		}
		if(isReloading)
		{
			reloadingTime -= Time.deltaTime;
			if(reloadingTime <= 0)
			   isReloading = false;
		}
		if (!isReloading)
		{
			if(playerHandler.ammo > 0)
			{
				if (Input.GetMouseButton (0)) {
					if (ballTime <= 0.0f) {
						//transform.parent.parent.camera.fieldOfView -= 5;
						audio.PlayOneShot (fireSound);
						//Instantiate(bullet, transform.position,transform.rotation);
						Instantiate (realBullet, transform.position, transform.rotation);
						ballTime += 0.1f;
						playerHandler.ammo --;
					}
				}
			}
			if (Input.GetKeyDown (KeyCode.R)) {
					audio.volume = 1;
					audio.PlayOneShot (reloadSound);
				isReloading = true;
				reloadingTime = 7.6f;
				playerHandler.ammo = 31;
					//audio.volume = 0.77f;
			}
			if (Input.GetMouseButtonDown (1)) {
					transform.parent.parent.GetComponent<MouseLook> ().sensitivityY = 0.8f;
					transform.parent.parent.parent.GetComponent<MouseLook> ().sensitivityX = 0.8f;
					Sight.gameObject.SetActive (false);
					transform.parent.parent.camera.fieldOfView = 20;
					weaponNoZoom.gameObject.SetActive (false);
					weaponWithZoom.gameObject.SetActive (true);
			}
			if (Input.GetMouseButtonUp (1)) {
					transform.parent.parent.camera.fieldOfView = 60;
					transform.parent.parent.GetComponent<MouseLook> ().sensitivityY = 5.0f;
					transform.parent.parent.parent.GetComponent<MouseLook> ().sensitivityX = 5.0f;
					Sight.gameObject.SetActive (true);
					weaponNoZoom.gameObject.SetActive (true);
					weaponWithZoom.gameObject.SetActive (false);
			}
		}
	}
}
