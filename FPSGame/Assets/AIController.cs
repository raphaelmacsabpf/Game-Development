using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour {

	public Vector3 newPos;
	public bool isMoving;
	public int choice;
	// Use this for initialization
	void Start () {
		isMoving = false;
		newPos = Vector3.zero;
		choice = 0;
	}
	void MoveTo(Vector3 newPosition)
	{
		newPos = newPosition;
		isMoving = true;
	}
	// Update is called once per frame
	void Update () {
		print (StaticsOfGame.mainPlayer.position.ToString ());
		MoveTo (StaticsOfGame.mainPlayer.transform.position);
		/*
		choice ++;
		if(choice % 600 == 0)
			MoveTo (StaticsOfGame.mainPlayer.transform.position);*/
		if(isMoving)
		{
			this.transform.Translate(Vector3.Normalize(newPos-this.transform.position) * 6 * Time.deltaTime);
		}
		if(Vector3.Distance(transform.position,this.newPos) < 0.9)
		{
			isMoving = false;
		}
	}
}
