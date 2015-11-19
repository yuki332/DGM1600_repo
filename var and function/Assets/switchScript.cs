using UnityEngine;
using System.Collections;

public class switchScript : MonoBehaviour {

	public int age = 4;

	// Use this for initialization
	void Start () {
		print ("age scale : 0 ~ 12 -> 1 / 13 ~ 18 -> 2 / 19 ~ 25 -> 3 / 26 ~ 35 -> 4 / 36 ~ up -> 5");
		switch (age) {
		case 5:
			print ("you look young!");
			break;
		case 4:
			print ("you are mature.");
			break;
		case 3:
			print ("you are in great age");
			break;
		case 2:
			print ("you are adult");
			break;
		case 1:
			print ("you are cute");
			break;
		}
	}

}
