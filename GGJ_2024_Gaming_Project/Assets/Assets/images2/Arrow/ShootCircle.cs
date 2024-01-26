using UnityEngine;

public class ShootCircle : MonoBehaviour
{
    public GameObject arrow;
    public GameObject circlePrefab;
    public KeyCode shootKey = KeyCode.Space;

    private Quaternion targetRotation;
    private bool canShoot = false;

    private void Start()
    {
        // Set initial rotation for the arrow
        targetRotation = arrow.transform.rotation;
    }

    private void Update()
    {
        // Rotate the arrow continuously
        float rotationSpeed = 1000.0f;
        targetRotation *= Quaternion.Euler(0, 0, rotationSpeed * Time.deltaTime);
        arrow.transform.rotation = targetRotation;

        // Enable shooting when suitable angle is found
        float angleThreshold = 10.0f;
        float currentAngle = Vector3.Angle(arrow.transform.up, Vector3.up);
        if (currentAngle <= angleThreshold)
        {
            canShoot = true;
        }
        else
        {
            canShoot = false;
        }

        // Shoot circle when shoot key is pressed and can shoot
        if (Input.GetKeyDown(shootKey) && canShoot)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        // Instantiate circle prefab
        GameObject circle = Instantiate(circlePrefab, arrow.transform.position, arrow.transform.rotation);

        // Apply force to the circle in the direction of the arrow
        float shootForce = 10.0f;
        Rigidbody2D circleRigidbody = circle.GetComponent<Rigidbody2D>();
        circleRigidbody.AddForce(arrow.transform.up * shootForce, ForceMode2D.Impulse);
    }
}