using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gadget1_Gravity : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) 
    { 
        // Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        if (collision.transform.tag == "Ball") 
        {
            Physics2D.gravity = new Vector2(-9.81f,9.81f);
            StartCoroutine(ChangeGravityAfterDelay());
        }
    }

    IEnumerator ChangeGravityAfterDelay()
    {
        yield return new WaitForSeconds(3f);
        Physics2D.gravity = new Vector2(0f, -9.81f);
        Destroy(this.gameObject);
    }
}
