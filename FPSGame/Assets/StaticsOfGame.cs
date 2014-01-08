using UnityEngine;
using System.Collections;

public class StaticsOfGame : MonoBehaviour {

	public Transform nonStaticMainPlayer;
	public static Transform mainPlayer;
	// Use this for initialization
	void Start () {
		StaticsOfGame.mainPlayer = nonStaticMainPlayer;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
