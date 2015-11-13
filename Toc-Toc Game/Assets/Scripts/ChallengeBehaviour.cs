using UnityEngine;
using System.Collections;

public class ChallengeBehaviour : MonoBehaviour {

	public GameObject challenge, dog, cow;
	private bool isInstantiated;

	// Use this for initialization
	void Start () 
	{
		isInstantiated = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch(Random.Range(0,2))
		{
			case 0:
				challenge = dog;
			break;

			case 1:
				challenge = cow;
			break;
		}

		if(isInstantiated == false)
		{
			print("")
			Instantiate(dog, this.transform.position, this.transform.rotation);
			isInstantiated = true;
		}

	}
}