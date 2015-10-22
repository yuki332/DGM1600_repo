using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour {
	//do while loop
	// Use this for initialization
	void Start () {
		bool eatFood = false;

		do {
			print ("taste food");
		} while(eatFood == true);

	}

}
