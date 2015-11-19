using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour {
	public int tasks = 10;
	// Use this for initialization
	void Start () {
		while(tasks > 0){
			Debug.Log ("you still have " + tasks + " tasks");
			tasks--;
		}
	}
}