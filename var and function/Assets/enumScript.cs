using UnityEngine;
using System.Collections;

public class enumScript : MonoBehaviour {

	enum game{rock, paper, scissors};

	// Use this for initialization
	void Start () {
		game myChoice;
		myChoice = game.rock;

		print (neverLoose (myChoice));
	}

	game neverLoose (game x)
	{
		if (x == game.rock)
			x = game.paper;
		else if (x == game.paper)
			x = game.scissors;
		else 
			x = game.rock;

		return x;
	}
}
