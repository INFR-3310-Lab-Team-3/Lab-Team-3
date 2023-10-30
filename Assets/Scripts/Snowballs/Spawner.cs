using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject snowball;

    bool hasSpawned = false;
    public bool isTriggerBased = false;
    bool seesPlayer = false;

    private void Start()
    {

    }

    private void Update()
    {
        if (!isTriggerBased)
        {
            if (!hasSpawned)
            {
                Instantiate(snowball, this.transform.position + new Vector3(0f, 0f, Random.Range(-5f, 5f)), Quaternion.identity);
                hasSpawned = true;
                StartCoroutine(ResetSpawner());
            }
        }
        else
        {
            if (!hasSpawned && seesPlayer)
            {
                Instantiate(snowball, this.transform.position + new Vector3(0f, 0f, Random.Range(-5f, 5f)), Quaternion.identity);
                hasSpawned = true;
                StartCoroutine(ResetSpawner());
            }
        }
        
    }

    IEnumerator ResetSpawner()
    {
        yield return new WaitForSeconds(Random.Range(3, 10));
        hasSpawned = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            seesPlayer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            seesPlayer = false;
        }
    }
}
