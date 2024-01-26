using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
		[SerializeField] private Vector3 offset;
		private Transform player;
		
    void Awake()
    {
       player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
       transform.position = Vector3.Lerp(transform.position, player.position - player.forward * 10 + offset, 1); 
			 transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), 1);
    }
}
