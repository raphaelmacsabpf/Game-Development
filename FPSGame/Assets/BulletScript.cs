using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	float velocidade;
	void Start () {
		velocidade = 150f * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,0,velocidade));
	
	}
	void OnCollisionEnter(Collision collision)
	{
		DestroyObject(gameObject);
	}
}
