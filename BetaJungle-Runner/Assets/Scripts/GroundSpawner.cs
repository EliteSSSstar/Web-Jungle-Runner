
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    //veriables
    public GameObject GroundTile;
    Vector3 nextSpawnPoint;


    // Start is called before the first frame update
   public void SpawnTile()
    {
        //allows ground tile to spawn when reaching the spawnpoint
        GameObject temp = Instantiate(GroundTile, nextSpawnPoint, Quaternion.identity);
        //Player will continue to move to spawn point
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }


    void Start()
    {
        for (int i = 0; i < 15; i++){
        //spawn tile to map some times to a runway
        SpawnTile();
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
