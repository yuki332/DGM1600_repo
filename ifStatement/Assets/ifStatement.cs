using UnityEngine;
using System.Collections;

public class ifStatement : MonoBehaviour {

	public float you = 0;
	public float early = 30;
	public float tooFar = 70;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			turn();

			you += Time.deltaTime * 5;	
	}
	void turn()
	{
		if (you < early) {
			print ("it's too fast to turn");
		} else if (you > tooFar) {
			print ("it's too late to turn");
		} else {
			print ("now you turn");
		}
	}

}
