using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float speed = 30;    // How fast the player moves
    public string axis = "Vertical";    // The axis to get direction from

    public bool isMobile = false;   // Set true when exporting to mobile
    public bool isPlayer1 = false;  // Used for mobile platform to distinguish players

    void FixedUpdate()
    {
        if (!isMobile)
        {
            // Moves the player based on the axis used
            float v = Input.GetAxisRaw(axis);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
        }
        else
        {   // All of this needs a major overhaul and debug
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            if (Camera.main.ScreenToWorldPoint(touch1.position).x < 0 && isPlayer1)
            {
                Vector3 pos = new Vector3(transform.position.x, Camera.main.ScreenToWorldPoint(touch1.position).y);
                transform.position = pos;
            }
            else if (Camera.main.ScreenToWorldPoint(touch2.position).x < 0 && isPlayer1)
            {
                Vector3 pos = new Vector3(transform.position.x, Camera.main.ScreenToWorldPoint(touch2.position).y);
                transform.position = pos;
            }
            else if (Camera.main.ScreenToWorldPoint(touch1.position).x > 0 && !isPlayer1)
            {
                Vector3 pos = new Vector3(transform.position.x, Camera.main.ScreenToWorldPoint(touch1.position).y);
                transform.position = pos;
            }
            else if (Camera.main.ScreenToWorldPoint(touch2.position).x > 0 && !isPlayer1)
            {
                Vector3 pos = new Vector3(transform.position.x, Camera.main.ScreenToWorldPoint(touch2.position).y);
                transform.position = pos;
            }
        }
    }
}