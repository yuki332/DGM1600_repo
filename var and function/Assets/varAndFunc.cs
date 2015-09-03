using UnityEngine;
using System.Collections;

public class varAndFunc : MonoBehaviour 
{
	int myInt = 60;
	// Use this for initialization
	void Start () {

		int first = devideByTwo (myInt);
		int second = multipleByThree (myInt);

		Debug.Log (first);
		Debug.Log (second);
	
	}

	int devideByTwo (int number)
	{
		int rel;
		rel = number / 2;
		return rel;
	}

	int multipleByThree (int number)
	{
		int rel;
		rel = number * 3;
		return rel;
	}
	
}
