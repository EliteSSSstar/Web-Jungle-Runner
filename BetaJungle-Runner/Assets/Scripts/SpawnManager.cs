using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject player; // Reference to the player object
    private float startDelay = 6;
    private float repeatRate = 10;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObstaclesWithDelay());
    }

    IEnumerator SpawnObstaclesWithDelay()
    {
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            // Get the player's current position
            Vector3 playerPos = player.transform.position;

            // Adjust the spawn position based on the player's z-coordinate
            Vector3 spawnPos = new Vector3(playerPos.x, playerPos.y, playerPos.z + 25);

            // Spawn the obstacle at the adjusted position
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

            yield return new WaitForSeconds(repeatRate);
        }
    }
}
