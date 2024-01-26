using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decreaseHP : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player=GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            GameObject director= GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().DecreaseHP();}
    }
}
