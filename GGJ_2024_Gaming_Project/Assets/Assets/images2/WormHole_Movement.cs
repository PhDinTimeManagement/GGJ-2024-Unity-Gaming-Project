using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormHole_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int rotateRate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.transform.rotation = Quaternion.Euler(0,0,Time.deltaTime*rotateRate);
        this.gameObject.transform.Rotate(Vector3.forward,rotateRate*Time.deltaTime);
    }
}