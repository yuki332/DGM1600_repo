using UnityEngine;
using System.Collections;

public class foreachLoops : MonoBehaviour {
	//for each loop
	// Use this for initialization
	void Start () {
		string[] people = new string[4];

		people[0] = "David";
		people[1] = "John";
		people[2] = "Lucas";
		people[3] = "Noah";

		foreach (string person in people) {
			print (person);
		}
	
	}

}
