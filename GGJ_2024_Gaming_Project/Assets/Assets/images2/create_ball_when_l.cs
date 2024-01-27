using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_ball_when_l : MonoBehaviour
{
    [SerializeField] GameObject ball;
    GameObject newBall;
    bool canCreate = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l") && canCreate)
        {
            canCreate = false;
            Invoke("create", 2.9f);
        }
    }

    void create()
    {
        newBall = Instantiate(ball);
        newBall.transform.position = new Vector3(17.6f, -14.8f, 0f);
        newBall.transform.Rotate(0f,0f,0f,Space.World);
        ball = newBall;
        canCreate = true;
    }
}
