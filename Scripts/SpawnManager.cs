using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> ballsPrefabs;

    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("SpawnBalls", 2.0f, 0.35f);
    }

    // Update is called once per frame 
    void Update()
    {
      
    }


    void SpawnBalls()
    {
        Instantiate(ballsPrefabs[Random.Range(0,4)], transform.position, Random.rotation);
    }
}
