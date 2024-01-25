using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowpointing : MonoBehaviour
{
    [SerializeField] private GameObject arrow;
    private Vector2 worldPosition;
    private Vector2 direction;

    void Update()
    {
        arrowMovement();
    }

    private void arrowMovement()
    {
        worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (worldPosition - (Vector2)arrow.transform.position).normalized;
        arrow.transform.right = direction;
    }
}
