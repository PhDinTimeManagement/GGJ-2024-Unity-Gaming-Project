using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wormhole_Logic : MonoBehaviour
{
    private Camera mainCamera;
    private GameObject fisrtWormhole;
    [SerializeField]private GameObject secondWormhole;
    [SerializeField]private int NumeberOfWhiteHole = 0;
    [SerializeField]private int maxWhiteHole = 1;
    [SerializeField]private float destroyTime = 12f;
    [SerializeField]private float destroyTime2 = 1f;
    private Vector3 worldPoint; 
    private float minX = -24f;
    private float maxX = 25f;
    private float minY = -14f;
    private float maxY = 17f;
    // Start is called before the first frame update
    void Start()
    {
        //newwormhole = GetComponent<GameObject>();
        mainCamera = Camera.main;
        Vector3 viewportPoint = new Vector3(1.2f, 1.8f, 0f); // Example point outside the camera's viewport
        // worldPoint = mainCamera.ViewportToWorldPoint(viewportPoint);
        // minX = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        // maxX = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        // minY = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        // maxY = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        //secondWormhole.SetActive(true); 
        fisrtWormhole = this.gameObject;
        //this.gameObject.SetActive(true);
        //fisrtWormhole.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {

        int randomNumber = Random.Range(1, 10000);
        if (randomNumber == 5 && NumeberOfWhiteHole < maxWhiteHole){
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Vector2 newPosition = new Vector2(randomX, randomY);
            fisrtWormhole.transform.position = newPosition;
            //fisrtWormhole.SetActive(true);
            NumeberOfWhiteHole ++;
            Camera mainCamera = Camera.main;
            
            StartCoroutine(DestroyWormHoleAfterDelay(fisrtWormhole,destroyTime));
            if (NumeberOfWhiteHole <= maxWhiteHole && NumeberOfWhiteHole > 0){
                NumeberOfWhiteHole--;
            }
            
            
        }
    }

    
    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.transform.CompareTag("Ball"))
    {
        Vector2 newPosition = TeleportObject(collision.gameObject);
        //GameObject wormholeExit = Instantiate(wormhole2, newPosition, Quaternion.identity) as GameObject;
        // If the object has a Rigidbody2D, use MovePosition for physics-based movement
        secondWormhole.transform.position = newPosition;
        //secondWormhole.SetActive(true);
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.MovePosition(newPosition);
        }
        else
        {
            collision.gameObject.transform.position = newPosition;
        }
        StartCoroutine(DestroyWormHoleAfterDelay(secondWormhole,destroyTime2));
    }
}


    Vector2 TeleportObject(GameObject obj)
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector2 newPosition = new Vector2(randomX, randomY);
        return newPosition;
        
    }
      IEnumerator DestroyWormHoleAfterDelay(GameObject wormhole,float delay)
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(delay);
        //wormhole.SetActive(false);
        wormhole.transform.position = worldPoint;
        
    }
}