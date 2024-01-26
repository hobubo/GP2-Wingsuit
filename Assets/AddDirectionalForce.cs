using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDirectionalForce : MonoBehaviour
{
	private enum Direction {Forward, Up};
	[SerializeField] private Direction direction;
	private Vector3 forceDirection;
	[SerializeField] private float force;
	[SerializeField] private float duration = 3;
	private bool _shouldAddForce;
	private float time;
	private float prevTime;
	private Rigidbody rb;
	
	void Awake()
	{
		rb = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
	}
	void Start()
	{
		prevTime = Time.time;
	 	switch(direction)
		{
			case Direction.Forward: forceDirection = transform.forward; 
					break;
			case Direction.Up: forceDirection = Vector3.up;
					break;
		}
	}

	void FixedUpdate()
	{
		time = Time.time - prevTime;
		if(time < duration)
		{
			rb.AddForce(forceDirection * force, ForceMode.Impulse);
		}
	}

	public void AddForce(GameObject other)
	{
		prevTime = Time.time;
		// rb = other.GetComponent<Rigidbody>();
	}

}

