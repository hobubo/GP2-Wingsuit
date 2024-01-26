using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour
{
	public UnityEvent<GameObject> onCollision;

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player")){
			print(true);
			print(other.gameObject);
			onCollision.Invoke(other.gameObject);
		}
	}
}
