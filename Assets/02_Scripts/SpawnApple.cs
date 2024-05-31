using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApple : MonoBehaviour
{
    public GameObject apple;
    //List<GameObject> apple;
    float spawnInterval;
    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = 0.5f;
        StartCoroutine(coSpawnApple());
    }

    // Update is called once per frame

    IEnumerator coSpawnApple()
    {
        while (true)
        {
            Instantiate(apple, transform.position, transform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }

    }
}
