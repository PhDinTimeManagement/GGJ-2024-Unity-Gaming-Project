using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMoving : MonoBehaviour
{
    [SerializeField] private GameObject cat;
    private Rigidbody2D arrowRigidbody;
    [SerializeField] private float shootForce = 500f;
    private bool canShoot = true;
    private float bulletLifeTime = 3.0f;

    void Start()
    {
        arrowRigidbody = cat.GetComponent<Rigidbody2D>();
        if (arrowRigidbody == null)
        {
            Debug.LogError("Arrow GameObject does not have a Rigidbody2D component.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && canShoot)
        {
            ShootArrowInRandomDirection();
            canShoot = false;
            Destroy(cat,bulletLifeTime);
        }
    }

    private void ShootArrowInRandomDirection()
    {
        if (arrowRigidbody != null)
        {
            // Generate a random direction
            float randomAngle = Random.Range(0, 360) * Mathf.Deg2Rad;
            Vector2 randomDirection = new Vector2(Mathf.Cos(randomAngle), Mathf.Sin(randomAngle));

            arrowRigidbody.AddForce(randomDirection * shootForce);
        }
    }
}