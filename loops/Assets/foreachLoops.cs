using UnityEngine;
using System.Collections;

public class foreachLoops : MonoBehaviour {
	//for each loop
	// Use this for initialization
	void Start () {
		string[] items = new string[3];

		items[0] = "first item";
		items[1] = "second item";
		items[2] = "third item";

		foreach (string item in items) {
			print (item);
		}
	
	}

}
