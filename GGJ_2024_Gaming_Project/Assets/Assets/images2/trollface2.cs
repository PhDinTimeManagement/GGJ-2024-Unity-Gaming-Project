using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trollface2 : MonoBehaviour
{
    public GameObject pictureObject;
    
    // Start is called before the first frame update
    // void Start()
    // {
    //     // Deactivate the picture at the start
    //     pictureObject.SetActive(false);
    // }


  void OnCollisionEnter2D(Collision2D collision)
   {
       if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Hit");
            // Activate the picture
            pictureObject.SetActive(true);

            // // Start the coroutine to deactivate the picture after 3 seconds
            StartCoroutine(DeactivatePictureAfterDelay(2.5f));
        }
  }
    
    IEnumerator DeactivatePictureAfterDelay(float delay)
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(delay);

        // Deactivate the picture
        pictureObject.SetActive(false);
    }
}