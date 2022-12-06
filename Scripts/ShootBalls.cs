using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBalls : MonoBehaviour
{
    public float speed;

    private float ballRangeZ = 10.0f;
    private float ballRangeX = 18.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(transform.position.z > ballRangeZ || transform.position.z < -ballRangeZ || transform.position.x > ballRangeX || transform.position.x < -ballRangeX)
        {
            Destroy(gameObject);
        }
    }
}
