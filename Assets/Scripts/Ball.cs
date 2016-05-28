using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{
    public float speed = 30;    // How fast the ball moves
    public GameObject trail;    // The trail renderer
    public GameObject hitMark;  // The hitmarker object

    void Start() 
    {
        // Launches the ball
        StartCoroutine(StartBall());
    }

    IEnumerator StartBall()
    {
        yield return new WaitForSeconds(1f);
        trail.SetActive(true);
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    public void ResetBall()
    {
        // Resets the ball to 0, 0 and launches it
        trail.SetActive(false);
        GetComponent<Rigidbody2D>().isKinematic = true;
        transform.position = new Vector3(0, 0);
        StartCoroutine(StartBall());
    }
    
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        // Returns the distance from the center of the racket
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Hit the left Racket?
        if (col.gameObject.name == "RacketLeft")
        {
            HitMarker();
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Hit the right Racket?
        if (col.gameObject.name == "RacketRight") 
        {
            HitMarker();
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;
            
            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

    void HitMarker()
    {
        GameObject clone = (GameObject)Instantiate(hitMark, transform.position, Quaternion.identity);
        clone.transform.localScale = new Vector3(5, 5, 1);
        Destroy(clone, 0.5f);
    }
}
