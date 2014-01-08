using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	// Use this for initialization
	public Transform cam;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D))
		{
			rigidbody.AddForce(new Vector3(10,0,0));
		}
		cam.position.Set(transform.position.x,0,0);
	}
}
