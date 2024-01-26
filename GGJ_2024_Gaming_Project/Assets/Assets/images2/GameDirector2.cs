using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector2 : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject hpGauge2;
    void Start()
    {
        this.hpGauge2= GameObject.Find("hpGauge2");
    }

    void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.L)){
            
        DecreaseHP();}
    }


    public void DecreaseHP(){
        this.hpGauge2.GetComponent<Image>().fillAmount-=0.5f; 
    }



//     void OnCollisionEnter2D(Collision2D collision)
// {
//     // Check if the colliding objects are the ones you're interested in
//     if ((collision.gameObject == object1 && collision.otherCollider.gameObject == object2) ||
//         (collision.gameObject == object2 && collision.otherCollider.gameObject == object1))
//     {
//         DecreaseHP();
        
        
//     }
// }
    
}
