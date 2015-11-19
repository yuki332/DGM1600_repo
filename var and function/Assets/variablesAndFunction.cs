using UnityEngine;
using System.Collections;

public class variablesAndFunction : MonoBehaviour
{   
	int myInt = 2;
	
	
	void Start ()
	{
		myInt = MultiplyByTwo(myInt);
		Debug.Log (myInt);
	}
	
	
	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 4;
		return ret;
	}
}