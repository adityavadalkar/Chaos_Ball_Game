
using UnityEngine;
using System.Collections;

public class ObstacleMovementLeft : MonoBehaviour
{

    private bool dirLeft = true;
    public float speed = 2.0f;

    void Update()
    {
        if (dirLeft)
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= -2.0f)
        {
            dirLeft = false;
        }

        if (transform.position.x >= 2)
        {
            dirLeft = true;
        }
    }
}