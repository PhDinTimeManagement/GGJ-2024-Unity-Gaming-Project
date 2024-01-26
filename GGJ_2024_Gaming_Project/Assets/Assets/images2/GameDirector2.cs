using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector2 : MonoBehaviour
{
     GameObject hpGauge2;
    void Start()
    {
        this.hpGauge2= GameObject.Find("hpGauge2");

    }
    void DecreaseHP2()
    {
        this.hpGauge2.GetComponent<Image>().fillAmount-=0.1f; // Adjust the decrease amount as per your requirement
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            Debug.Log("Player collided with the ball");
            DecreaseHP2();
        }
    }
}
