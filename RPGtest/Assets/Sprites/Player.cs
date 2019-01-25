using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Vector2 dir;
    public float speed = 10;
    private int lastDir = 2;

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            dir = Vector2.right;
            lastDir = 1;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            dir = Vector2.left;
            lastDir = 3;
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            dir = Vector2.up;
            lastDir = 0;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            dir = Vector2.down;
            lastDir = 2;
        }
        else
        {
            dir = Vector2.zero;
        }
        transform.position = transform.position + (Vector3)(dir * Time.deltaTime * speed);
    }

}
