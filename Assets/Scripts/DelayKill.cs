using UnityEngine;
using System.Collections;

public class DelayKill : MonoBehaviour
{
    public float timeToWait = 10f;  // The time to delay in seconds

    void Start()
    {
        StartCoroutine(Kill());
    }

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(timeToWait);
        Destroy(gameObject);
    }
}