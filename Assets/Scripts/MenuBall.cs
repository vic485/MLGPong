using UnityEngine;

public class MenuBall : MonoBehaviour
{
    public GameObject hitMark;  // the hitmarker prefab

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if (colInfo.collider.tag == "Player")
        {
            // If we hit the player, display the hitmarker and play the sound
            GetComponent<AudioSource>().Play();
            GameObject clone = (GameObject)Instantiate(hitMark, new Vector2(transform.position.x, transform.position.y - 0.2f), Quaternion.identity);
            Destroy(clone, 0.25f);
        }
    }

    void Update()
    {
        // Lock the ball to an x position of 3
        transform.position = new Vector3(3, transform.position.y, transform.position.z);
        // Maintain a "constant" velocity in either direction
        if (GetComponent<Rigidbody2D>().velocity.y < 5 && GetComponent<Rigidbody2D>().velocity.y > -5 && GetComponent<Rigidbody2D>().velocity.y != 0)
        {
            if (GetComponent<Rigidbody2D>().velocity.y > 0)
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
            else
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -5);
        }
    }
}