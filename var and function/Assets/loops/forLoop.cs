using UnityEngine;
using System.Collections;

public class forLoop : MonoBehaviour {

	public int tasks = 10;

	void Start () {
		for(int i = 0; i <= tasks; i++){
			Debug.Log(i + " task finised");
		}
	}
}