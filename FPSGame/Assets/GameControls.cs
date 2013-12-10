using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
public class GameControls : MonoBehaviour 
{
	public Transform bullet;
	public Transform realBullet;
	public AudioClip fireSound;
	public Transform weaponNoZoom;
	public Transform weaponWithZoom;
	public Transform Sight;

	void Start() {
		Screen.lockCursor = true;
		Screen.showCursor = false;
	}
	
	void Update() {
		if(Input.GetMouseButtonDown(0))
		{
			//transform.parent.parent.camera.fieldOfView -= 5;
			audio.PlayOneShot(fireSound);
			Instantiate(bullet, transform.position,transform.rotation);
			Instantiate(realBullet, transform.position,transform.rotation);
		}
		if(Input.GetMouseButtonDown(1))
		{
			transform.parent.parent.GetComponent<MouseLook>().sensitivityY = 0.8f;
			transform.parent.parent.parent.GetComponent<MouseLook>().sensitivityX = 0.8f;
			Sight.gameObject.SetActive (false);
			transform.parent.parent.camera.fieldOfView = 20;
			weaponNoZoom.gameObject.SetActive(false);
			weaponWithZoom.gameObject.SetActive(true);
		}
		if(Input.GetMouseButtonUp(1))
		{
			transform.parent.parent.camera.fieldOfView = 60;
			transform.parent.parent.GetComponent<MouseLook>().sensitivityY = 5.0f;
			transform.parent.parent.parent.GetComponent<MouseLook>().sensitivityX = 5.0f;
			Sight.gameObject.SetActive (true);
			weaponNoZoom.gameObject.SetActive(true);
			weaponWithZoom.gameObject.SetActive(false);
		}
	}
}
