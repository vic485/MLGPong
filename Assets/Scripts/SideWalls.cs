using UnityEngine;

public class SideWalls : MonoBehaviour
{
    public GameManager gm;  // The game manager object
    public GameObject particles;    // Particles to display

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // if the ball crosses the goal
        if (hitInfo.name == "Ball")
        {
            // Creates particles at the ball, resets it, and calls the methods for scoring
            Vector3 pos = hitInfo.transform.position;
            string wallName = transform.name;
            gm.Score(wallName);
            hitInfo.gameObject.SendMessage("ResetBall");
            GameObject clone = (GameObject)Instantiate(particles, pos, Quaternion.identity);
            Destroy(clone, 3f);
        }
    }
}