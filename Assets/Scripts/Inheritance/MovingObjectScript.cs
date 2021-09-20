using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectScript : MonoBehaviour
{
    protected float speed = 2f;
    protected bool updateSpeed = false;

    private void Start()
    {
        updateSpeed = true;
    }

    private void FixedUpdate()
    {
        if (updateSpeed)
        {
            GetComponent<Rigidbody>().velocity = transform.forward * speed;
            updateSpeed = false;
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
