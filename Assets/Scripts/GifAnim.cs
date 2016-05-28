using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class GifAnim : MonoBehaviour
{
    public Sprite[] sprites;
    public int FPS = 10;

    void Update()
    {
        int index = (int)(Time.time * FPS) % sprites.Length;
        GetComponent<SpriteRenderer>().sprite = sprites[index];
    }
}