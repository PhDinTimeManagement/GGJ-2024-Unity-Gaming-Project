using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_ball_when_a : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject ball;
    GameObject newBall;
    bool canCreate=true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a")&&canCreate)
        {
            canCreate = false;
            Invoke("create",2.9f);
        }
    }

    void create()
    {
        newBall = Instantiate(ball);
        newBall.transform.position = new Vector3(-16.9f, -14.7f, 0f);
        newBall.transform.Rotate(0f,0f,0f,Space.World);
        ball = newBall;
        canCreate = true;
    }
}
