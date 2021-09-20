using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MovingObjectScript
{
    bool isFast;
    float slowSpeed = 2f;
    float fastSpeed = 6f;

    public void ToggleSpeed(bool newIsFast)
    {
        isFast = newIsFast;
        if (isFast) speed = fastSpeed;
        else speed = slowSpeed;

        updateSpeed = true;
    }

    public void OnMouseDown()
    {
        ToggleSpeed(!isFast);
    }
}
