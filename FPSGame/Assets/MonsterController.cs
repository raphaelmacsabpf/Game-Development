using UnityEngine;
using System.Collections;


public class MonsterController : MonoBehaviour {
	public Transform leader;
	public Transform follower;
	public CharacterController followerCC;
	public bool toMove;
	public AudioClip groan_006;
	public AudioClip groan_005;
	public AudioClip groan_004;
	public AudioClip groan_003;
	public AudioClip hurt;
	public float soundTime;
	public float attackTime;
	public float health;
	float speed;
	// Use this for initialization
	void Start () {
		speed = 8.0f * Random.value;
		soundTime = (Random.value * 4);
		attackTime = 0.0f;
		health = 100.0f;
		toMove = false;
		followerCC = follower.GetComponent<CharacterController>();
	}
	public void Death()
	{
		DestroyObject (this.gameObject);
	}

	// Update is called once per frame
	void Update () {
		soundTime += Time.deltaTime;
		attackTime += Time.deltaTime;
		if (soundTime >= 5.0 + (Random.value * 4)) 
		{
			float rand = Random.value;
			if(rand >= 0.0f && rand < 0.25f)
				audio.PlayOneShot (groan_003);
			else if(rand >= 0.25f && rand < 0.50f)
				audio.PlayOneShot (groan_004);
			else if(rand >= 0.50f && rand < 0.75f)
				audio.PlayOneShot (groan_005);
			else if(rand >= 0.75f && rand < 1.0f)
				audio.PlayOneShot (groan_006);
			audio.maxDistance = 30.0f;
			soundTime = 0.0f;
		}
		if(toMove != false)
		{
			follower.LookAt(leader);
			if(Vector3.Distance(this.gameObject.transform.position, leader.transform.position) > 2)
				followerCC.SimpleMove( follower.forward * speed );
			else
			{
				if(attackTime > 0.8)
				{
					GameObject.Find ("GameHandler").GetComponent<StaticsOfGame>().nonStaticMainPlayer.GetComponent<PlayerHandler>().health -= 14.0f * Random.value;
					attackTime = 0.0f;
					audio.PlayOneShot (hurt);
				}
			}
			follower.GetComponent<Animator>().speed = 1.0f;
		}
		else
		{
			if(Vector3.Distance(this.gameObject.transform.position, leader.transform.position) < 40 && Vector3.Distance(this.gameObject.transform.position, leader.transform.position) > 3)
				toMove = true;
			follower.GetComponent<Animator>().speed = 0.0f;
		}
	}
}
