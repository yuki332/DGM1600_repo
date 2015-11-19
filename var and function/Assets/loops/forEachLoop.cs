using UnityEngine;
using System.Collections;

public class forEachLoop : MonoBehaviour {
	public string[] nameArray = {"john", "eric", "brandon", "ryan", "kevin"};
	// Use this for initialization
	void Start () {
		foreach (string name in nameArray) {
			print (name);
		}
	}

}
