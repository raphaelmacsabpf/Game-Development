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
		velocidade = 177*Time.deltaTime;
		transform.Translate(new Vector3(0,0,velocidade));
		if(transform.position.y > 2000 || transform.position.x > 2000 || transform.position.z > 2000 || transform.position.y < -2000 || transform.position.x < -2000 || transform.position.z < -2000)
			DestroyBullet();
	
	}
	void DestroyBullet()
	{
		//print ("Tempo de vida: " + timeOfLife);
		DestroyObject(gameObject);

	}
	void OnTriggerEnter(Collider collision)
	{
		if(this.tag == "RealBullet" && collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "RealBullet"&& collision.gameObject.tag != "Player")
		{
			if(collision.gameObject.tag == "Enemy")
			{
				MonsterController gt = collision.gameObject.GetComponent<MonsterController>();
				gt.toMove = true;
				gt.health -= 11.0f;
				if (gt.health <= 0.0f)
				{
					gt.Death();

				}
			}
			DestroyBullet();
		}

	}
}
