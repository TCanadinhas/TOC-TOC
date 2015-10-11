using UnityEngine;
using System.Collections;

public class ChallengeBehaviour : MonoBehaviour {

	public GameObject challenge, dog;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Instantiate(dog, this.transform.position, this.transform.rotation);
	}
}
