using UnityEngine;
using System.Collections;

public class GameControls : MonoBehaviour 
{
	public Transform brick;
	public float offset;
	
	void Update() {
		if(Input.GetKey(KeyCode.Return))
		{
			Transform t = (Transform) Instantiate(brick, transform.position, transform.rotation);
			t.renderer.material.color = new Color(Random.value * 5,Random.value * 5, Random.value * 5);
		}
	}
}
