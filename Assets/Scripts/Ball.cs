using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody ballRigidbody;
    private float launchForce = 30;
    private float minSpawnPositionX = 8.4f;
    private float maxSpawnPositionX = 8.2f;
    private float spawnPositionY = -10;
    private float spawnPositionZ = 15;
    private static bool spawnOnTheRight = true;

    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.AddForce(Vector3.up * launchForce, ForceMode.Impulse);

        transform.position = new Vector3(RandomSpawnPositionX(), spawnPositionY, spawnPositionZ);
    }

    float RandomSpawnPositionX()
    {
        if (spawnOnTheRight)
        {
            spawnOnTheRight = !spawnOnTheRight;
            return Random.Range(minSpawnPositionX, maxSpawnPositionX);
        }
        else
        {
            spawnOnTheRight = !spawnOnTheRight;
            return Random.Range(-minSpawnPositionX, -maxSpawnPositionX);
        }
    }
}
