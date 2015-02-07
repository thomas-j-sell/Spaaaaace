using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
		rigidbody.velocity = transform.forward * speed;
	}

	void increaseSpeed ()
	{
		speed = speed + 1.0f;
	}
}
