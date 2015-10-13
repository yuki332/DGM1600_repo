using UnityEngine;
using System.Collections;

public class whileLoops : MonoBehaviour {
	//while loops
	int iPhoneInStock = 10;
	// Use this for initialization
	void Start () {
		while (iPhoneInStock > 0) {
			Debug.Log ("We have " + iPhoneInStock + " iPhone in stock!");
			iPhoneInStock--;
		}
	}
}
