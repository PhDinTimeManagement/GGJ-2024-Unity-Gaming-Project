using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickman_right: MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.L)){
        this.animator.SetTrigger("rightTrigger");}
    }
}
