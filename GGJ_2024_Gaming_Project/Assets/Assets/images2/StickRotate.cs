using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickRotate : MonoBehaviour
{
    public bool canRotate = false;
    public float RotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(canRotate){transform.Rotate(0,0,RotSpeed * Time.deltaTime);}
    }

    void OnCollisionEnter2D(Collision2D col) {
        canRotate = false;
    }
}