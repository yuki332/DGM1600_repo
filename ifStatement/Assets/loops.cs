using UnityEngine;
using System.Collections;

public class loops : MonoBehaviour {
	public int num = 0;
	// Use this for initialization
	void Start () {
		print ("count one to ten");
		for (int i = 0; i < 11; i++) {
			print ("number" + i);
		}
		print ("done!");
	}

}
