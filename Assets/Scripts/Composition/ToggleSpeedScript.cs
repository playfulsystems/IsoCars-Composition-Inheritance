using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovingScript))]
public class ToggleSpeedScript : MonoBehaviour
{
    MovingScript moveScript;
    bool isFast;
    float slowSpeed = 2f;
    float fastSpeed = 6f;

	public void Start()
	{
        moveScript = GetComponent<MovingScript>();
	}

	public void ToggleSpeed(bool newIsFast)
    {
        isFast = newIsFast;
        if (isFast) moveScript.speed = fastSpeed;
        else moveScript.speed = slowSpeed;

        moveScript.updateSpeed = true;
    }

    public void OnMouseDown()
    {
        ToggleSpeed(!isFast);
    }
}
