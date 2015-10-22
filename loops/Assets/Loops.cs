using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {
	//ForLoop
	public int num = 4;
	// Use this for initialization
	void Start () {
		for (int i = 0; i <= num; i++)
			Debug.Log ("counting numbers: " + i);
	}

}