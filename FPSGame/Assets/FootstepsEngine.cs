using UnityEngine;
using System.Collections;

public class FootstepsEngine : MonoBehaviour {

	public AudioClip a1;
	public AudioClip a2;
	public AudioClip a3;
	public AudioClip a4;
	float soundTime;
	// Use this for initialization
	void Start () {
		soundTime = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		soundTime += Time.deltaTime;

		if (this.GetComponent<CharacterController> ().velocity.magnitude >= 1.0f)
			if (soundTime >= 0.37f)
			{
				float rand = Random.value;
				if(rand >= 0.0f && rand < 0.25f)
					audio.PlayOneShot (a1);
				else if(rand >= 0.25f && rand < 0.50f)
					audio.PlayOneShot (a2);
				else if(rand >= 0.50f && rand < 0.75f)
					audio.PlayOneShot (a3);
				else if(rand >= 0.75f && rand < 1.0f)
					audio.PlayOneShot (a4);
				soundTime = 0.0f;
			}
	}
}
