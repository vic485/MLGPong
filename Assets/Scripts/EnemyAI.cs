using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public Transform ball;
    public float moveSpeed = 10f;

    void FixedUpdate()
    {
        Vector3 v = transform.position;
        v.y = ball.position.y;
        if (ball.position.x >= 0)
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            transform.position = Vector3.MoveTowards(transform.position, v, moveSpeed * Time.deltaTime);
        }
        else
            GetComponent<Rigidbody2D>().isKinematic = true;
    }
}
