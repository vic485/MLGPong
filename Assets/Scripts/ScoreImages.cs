using UnityEngine;
using System.Collections;

public class ScoreImages : MonoBehaviour
{
    public GameObject[] images; // image prefabs to display

    public void Spawn()
    {
        // Set a random image and duration
        int num = Random.Range(0, images.Length);
        float time = Random.Range(1f, 6f);

        // Create the image as a new game object at a random location
        GameObject clone = (GameObject)Instantiate(images[num], new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity);
        // Give this image a random rotation on the z axis
        clone.transform.eulerAngles = new Vector3(clone.transform.eulerAngles.x, clone.transform.eulerAngles.y, Random.Range(0f, 360f));
        // Give this image a random size
        int scale = Random.Range(3, 6);
        clone.transform.localScale = new Vector3(scale, scale, clone.transform.localScale.z);

        // Destroy after a predetermined time
        Destroy(clone, time);
    }
}