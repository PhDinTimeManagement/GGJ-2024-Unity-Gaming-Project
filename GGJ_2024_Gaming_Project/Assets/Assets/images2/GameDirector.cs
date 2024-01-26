using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    //Gameobject objectA;
    //Gameobject objectB;

    GameObject hpGauge;
    void Start()
    {
        this.hpGauge= GameObject.Find("hpGauge");
    }

    void Update()
    {
    }


    public void DecreaseHP(){
        this.hpGauge.GetComponent<Image>().fillAmount-=0.1f; 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            Debug.Log("Player collided with the ball");
            DecreaseHP();
        }
    }

    
}