using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFace : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]Sprite[] picture;
    [SerializeField]SpriteRenderer ball1;
    [SerializeField]SpriteRenderer ball2;
    int random;
    void Start()
    {
        RandomNumber();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomNumber()
    {
        random = Random.Range(1,picture.Length+1);
        ball1.sprite = picture[random - 1];
        random = Random.Range(1, picture.Length + 1);
        ball2.sprite = picture[random - 1];
    }
}
