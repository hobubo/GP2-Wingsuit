using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
		[SerializeField] private float speed;
		private Rigidbody rb;	
		private Vector2 inputAxis;
		private Vector3 rotation;
	
    void Awake()
    {
			rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
			inputAxis = new Vector3(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
			rotation.x = inputAxis.x * 25;
			rotation.y += inputAxis.y * 1.5f;	
			rotation.z = -inputAxis.y * 20;
    	// rb.velocity = transform.forward * (speed + rotation.x);
  			var friction = - new Vector3(rb.velocity.x, 0, rb.velocity.z);
				rb.AddForce(transform.forward * (speed + rotation.x/3), ForceMode.Impulse);
				rb.AddForce(-rb.velocity * speed, ForceMode.Acceleration);
			rb.rotation = Quaternion.Euler(rotation);
    }
}
