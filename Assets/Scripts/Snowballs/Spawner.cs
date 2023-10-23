using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject snowball;

    int numOfSnowballs;

    bool hasSpawned = false;

    private void Start()
    {
        numOfSnowballs = Random.Range(1, 3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && hasSpawned == false)
        {
            while (numOfSnowballs > 0)
            {
                Instantiate(snowball, this.transform.position + new Vector3(0f, 0f, Random.Range(-5f, 5f)), Quaternion.identity);

                numOfSnowballs--;
            }

            hasSpawned = true;
        }
    }
}
