using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DIRECTION
{
    LEFT,
    RIGHT
}

public class Pendulum : MonoBehaviour
{
    DIRECTION currentDirection = DIRECTION.RIGHT;
    const float moveStep = 0.5f;
    const float breakPoint = 200f;
    float pos = 0f;

    void Update()
    {
        switch (currentDirection)
		{
            case DIRECTION.RIGHT:
            {
			    this.transform.Translate(Vector3.right * moveStep * Time.deltaTime);
				pos += moveStep;
                if (pos > breakPoint)
                {
                    currentDirection = DIRECTION.LEFT;
                }
                break;
            }
            case DIRECTION.LEFT:
            {
                this.transform.Translate(Vector3.left * moveStep * Time.deltaTime);
                pos -= moveStep;
                if (pos < -breakPoint)
				{
                    currentDirection = DIRECTION.RIGHT;
				}
                break;
            }
        }
	}
}