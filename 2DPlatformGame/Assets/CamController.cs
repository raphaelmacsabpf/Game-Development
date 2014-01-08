using UnityEngine;
using System.Collections;

public class CamController : MonoBehaviour {

	public Transform ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position.Set(ball.position.x,transform.position.y,transform.position.z);
	}
}
