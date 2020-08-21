using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallThing : MonoBehaviour {

    public GameObject ballPrefab;

    public void SpawnBall()
    {
        Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        GameObject spawnedBall = Instantiate(ballPrefab, position, transform.rotation);
    }
}
