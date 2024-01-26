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
        

        if(Input.GetKeyDown(KeyCode.A)){
            
        DecreaseHP();}
    }


    public void DecreaseHP(){
        this.hpGauge.GetComponent<Image>().fillAmount-=2.0f; 
    }



//     void OnCollisionEnter2D(Collision2D collision)
// {
//     // Check if the colliding objects are the ones you're interested in
//     if ((collision.gameObject == objectA && collision.otherCollider.gameObject == objectB)
//         
//     {
//         DecreaseHP();
        
        
//     }
// }
    
}
