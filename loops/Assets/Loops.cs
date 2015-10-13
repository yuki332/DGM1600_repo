using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {
	//ForLoop
	int numSibrings = 4;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < numSibrings; i++)
			Debug.Log ("counting sibrings: " + i);
	}

}
