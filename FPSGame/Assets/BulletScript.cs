using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	float velocidade;
	void Start () {
		velocidade = 277 * Time.deltaTime;
		renderer.material.color = new Color(Random.value * 5,Random.value * 5, Random.value * 5);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,0,velocidade));
		/*if(transform.position.y > 2000 || transform.position.x > 2000 || transform.position.z > 2000 || transform.position.y < -2000 || transform.position.x < -2000 || transform.position.z < -2000)
			DestroyObject(gameObject);*/
	
	}
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag != "Bullet")
		{
			print ("Nome" + collision.gameObject.name);
			DestroyObject(gameObject);
		}
	}
}
