using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTriggerScript : MovingObjectScript
{
	private void OnTriggerEnter(Collider other)
	{
		Destroy(gameObject);
	}
}
