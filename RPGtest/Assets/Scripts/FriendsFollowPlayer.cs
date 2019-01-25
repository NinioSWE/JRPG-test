using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendsFollowPlayer : MonoBehaviour
{

    [SerializeField]
    List<GameObject> Friends = new List<GameObject>();

    public float speed;

    private Vector3 lastCameraPos;

    private void Start()
    {
        Friends.Add(gameObject);
    }

    private void Update()
    {
        MoveTowardsMouse();
    }

    public void MoveBody(float speed)
    {
        for (int i = 1; i < Friends.Count; i++) {

            Vector2 currentPos = Friends[i].transform.position;
            Vector2 lastPos = Friends[i - 1].transform.position;

            float size = Friends[i].GetComponent<CircleCollider2D>().radius;

            float dx = currentPos.x - lastPos.x;
            float dy = currentPos.y - lastPos.y;

            var angle = Mathf.Atan2(dy, dx);

            var nx = 2 * size * Mathf.Cos(angle);
            var ny = 2 * size * Mathf.Sin(angle);

            currentPos.x = nx + lastPos.x;
            currentPos.y = ny + lastPos.y;

            Friends[i].transform.position = Vector2.MoveTowards(Friends[i].transform.position, currentPos, speed);

        }
    }

    void MoveTowardsMouse()
    {
        if (Input.GetMouseButton(0)) {

            transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), Time.deltaTime * speed);

            lastCameraPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Mathf.Abs(transform.position.x - lastCameraPos.x) > 0.01f || Mathf.Abs(transform.position.y - lastCameraPos.y) > 0.01f) {

            transform.position = Vector2.MoveTowards(transform.position, lastCameraPos, Time.deltaTime * speed);
        }
    }
}
