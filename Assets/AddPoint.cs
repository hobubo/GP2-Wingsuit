using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
	private Counter counter;

	void Awake() 
	{
		counter = GameObject.FindWithTag("ScoreManager").GetComponent<Counter>();
	}

	void AddNewPoint()
	{
		counter.Increase();
	}



}
