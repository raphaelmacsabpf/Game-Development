using UnityEngine;
using System.Collections;

public class GameControls : MonoBehaviour 
{
	public Transform brick;
	public float offset;
	
	void Update() {
		if(Input.GetMouseButtonDown(0))
		{
			Transform t = (Transform) Instantiate(brick, transform.position, transform.rotation);
		}
	}
}
