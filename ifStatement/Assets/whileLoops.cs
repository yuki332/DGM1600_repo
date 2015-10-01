using UnityEngine;
using System.Collections;

public class whileLoops : MonoBehaviour {
	int letter = 3;
	// Use this for initialization
	void Start () {
		print("start writing letters");

		while(letter > 0){
			print ("i wrote one");
			letter--;
		}

		print("I've done");
	}
}
