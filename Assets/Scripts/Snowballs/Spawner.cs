using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject snowball;

    bool hasSpawned = false;

    private void Start()
    {

    }

    private void Update()
    {
        if (!hasSpawned)
        {
            Instantiate(snowball, this.transform.position + new Vector3(0f, 0f, Random.Range(-5f, 5f)), Quaternion.identity);
            hasSpawned = true;
            StartCoroutine(ResetSpawner());
        }
    }

    IEnumerator ResetSpawner()
    {
        yield return new WaitForSeconds(Random.Range(3, 10));
        hasSpawned = false;
    }

    /*private void OnTriggerEnter(Collider other)
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
    }*/
}
