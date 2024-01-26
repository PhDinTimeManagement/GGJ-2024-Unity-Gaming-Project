using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalGravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Physics2D.gravity = new Vector2(3*x, 3*y);
    }
}
