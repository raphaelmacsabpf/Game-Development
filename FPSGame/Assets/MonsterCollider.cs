using UnityEngine;
using System.Collections;

public class MonsterCollider : MonoBehaviour {

	public Transform Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Player.position;
	}
	void OnTriggerEnter(Collider collision)
	{
		print ("Minha layer = " + this.gameObject.layer);
		if (collision.gameObject.tag == "Enemy")
		{
			print ("gg");
			collision.GetComponent<MonsterController>().toMove = true;
			print ("Antiga Layer" + collision.gameObject.layer);
			collision.gameObject.layer = 13;
			print ("Nova Layer" + collision.gameObject.layer);
		}
		/*if(this.tag == "RealBullet" && collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "RealBullet"&& collision.gameObject.tag != "Player")
		{
			
			print("tivemos colisao com tag = " + collision.gameObject.tag + "pela  tag = " + this.tag);
			if(collision.gameObject.tag == "Enemy")
			{
				collision.GetComponent<MonsterController>().toMove = true;
				collision.GetComponent<MonsterController>().health -= 11.0f;
				if (collision.GetComponent<MonsterController>().health <= 0.0f)
					DestroyObject (collision.gameObject);
			}
			DestroyBullet();
		}*/
	}
}
