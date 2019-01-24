using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Vector2 dir;
    public float speed = 10;

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            dir = Vector2.right;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            dir = Vector2.left;
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            dir = Vector2.up;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            dir = Vector2.down;
        }
        else
        {
            dir = Vector2.zero;
        }
        transform.position = transform.position + (Vector3)(dir * Time.deltaTime * speed);
    }

}
