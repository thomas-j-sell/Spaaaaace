using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
	void Start ()
	{
		rigidbody.angularVelocity = Random.insideUnitSphere * Random.value * 5;
	}
}
