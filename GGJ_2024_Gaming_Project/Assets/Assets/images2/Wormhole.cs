using UnityEngine;
using System.Collections;

public class Wormhole : MonoBehaviour
{
    [SerializeField] public GameObject firstWormhole;
    [SerializeField] public GameObject secondWormhole;

    void Start()
    {
        secondWormhole.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("questionBall"))
        {
            secondWormhole.SetActive(true);
            TeleportObject(other.gameObject);
            StartCoroutine(DeactivateSecondWormhole());
        }
    }

    void TeleportObject(GameObject obj)
    {
        obj.transform.position = secondWormhole.transform.position;
        firstWormhole.SetActive(false);
    }

    IEnumerator DeactivateSecondWormhole()
    {
        yield return new WaitForSeconds(2);
        secondWormhole.SetActive(false);
    }
}
