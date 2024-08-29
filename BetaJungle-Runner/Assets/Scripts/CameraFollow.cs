using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Veriables
    public Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //camera stays on player position
        offset = transform.position - player.position;
    }

    // Update is called once per frame
     void Update()
    {
        //update Camera to follow player
        // transform.position = player.position + offset;

        //update camera to stay center of platform
         Vector3 targetPos = player.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
