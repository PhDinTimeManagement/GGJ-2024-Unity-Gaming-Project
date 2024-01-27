using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallThrow : MonoBehaviour
{
    public GameObject ball;
    Vector2 direction = new Vector2(1.0f, 1.0f);
    public float Power;

    void Start()
    {
        // Initially disable the ball
        ball.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(DelayedAppearanceAndThrow());
        }
    }

    IEnumerator DelayedAppearanceAndThrow()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(0.5f);

        // Make the ball active (visible) and then throw it
        ball.SetActive(true);
        Throw();
    }


    void Throw(){
        direction = direction;
        ball.GetComponent<Rigidbody2D>().isKinematic = false;
        ball.GetComponent<Rigidbody2D>().AddForce(direction * Power);
        ball.GetComponent<StickRotate>().canRotate = true;
    }
}