using UnityEngine;
using System.Collections;

public class NewPlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			this.gameObject.transform.rigidbody.AddForce(new Vector3(10,10,10));
		}
	
	}
}
