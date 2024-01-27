using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gadget2_Random : MonoBehaviour
{
    private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            TeleportObject(collision.gameObject);
        }
        Destroy(this.gameObject);
    }
    
    void TeleportObject(GameObject obj)
    {
        float minX = -24f;
        float maxX = 25f;
        float minY = -15f;
        float maxY = 18f;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector2 newPosition = new Vector2(randomX, randomY);
        obj.transform.position = newPosition;
    }
}