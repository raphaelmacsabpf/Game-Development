using UnityEngine;using System.Collections;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	float velocidade;
	float timeOfLife;
	void Start () {
		timeOfLife = 0.0f;
		renderer.material.color = new Color(0,0,0);
	}
	
	// Update is called once per framem
	void Update () {
		timeOfLife += Time.deltaTime;
		velocidade = 277*Time.deltaTime;
		transform.Translate(new Vector3(0,0,velocidade));
		if(transform.position.y > 2000 || transform.position.x > 2000 || transform.position.z > 2000 || transform.position.y < -2000 || transform.position.x < -2000 || transform.position.z < -2000)
			DestroyBullet();
	
	}
	void DestroyBullet()
	{
		print ("Tempo de vida: " + timeOfLife);
		DestroyObject(gameObject);

	}
	void OnTriggerEnter(Collider collision)
	{
		if(collision.transform.parent != null)
		{
			if(collision.transform.parent.gameObject.tag == "Enemy")
			{ 
				GameObject d = collision.transform.GetComponentInChildren<EnemyScript>().bodyId;
				d.rigidbody.constraints = RigidbodyConstraints.None;
				d.rigidbody.AddForce(new Vector3(Random.value* 100,Random.value* 100,Random.value* 100));
			}
				//DestroyObject(collision.transform.parent.gameObject);
		}
		if(collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "Player")
		{
			DestroyBullet();
		}

	}
}
