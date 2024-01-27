using System.Collections;
using UnityEngine;

public class Gadget4 : MonoBehaviour
{
    public float scaleFactor = 1.5f; // The scale change per second
    public float duration = 2.0f; // The duration of each scale change
    public float maxScale = 2.0f; // The maximum scale
    public float minScale = 0.5f; // The minimum scale

    private bool isChangingScale = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") && !isChangingScale)
        {
            // Start changing scale
            isChangingScale = true;
            StartCoroutine(ToggleScale());
        }
    }

    IEnumerator ToggleScale()
    {   
        float begintime = Time.time;
        while (isChangingScale && Time.time <= begintime + 5.0f)
        {
            // Grow
            float endTime = Time.time + duration;
            while (Time.time < endTime && transform.localScale.x < maxScale)
            {
                transform.localScale *= (1.0f + scaleFactor * Time.deltaTime);
                yield return null;
            }

            // Shrink
            endTime = Time.time + duration;
            while (Time.time < endTime && transform.localScale.x > minScale)
            {
                transform.localScale /= (1.0f + scaleFactor * Time.deltaTime);
                yield return null;
            }
        }
        Destroy(this.gameObject);
    }
}