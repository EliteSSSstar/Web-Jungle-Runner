using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    public bool gameOver = false;
    public bool isOnGround = true;

    private int keyCollisionCount = 0;
    private bool keyCollisionRegistered = false;
    private float collisionCooldown = 0.5f; // 0.5 seconds cooldown
    private float lastCollisionTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Reset the collision registered flag if enough time has passed
        if (Time.time - lastCollisionTime > collisionCooldown)
        {
            keyCollisionRegistered = false;
        }
    }

    // Check if player enters a trigger and take appropriate action
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground")) 
        {
            isOnGround = true;
        } 
        else if (other.gameObject.CompareTag("Obstacle")) 
        {
            Debug.Log("Oops");
        } 
        else if (other.gameObject.CompareTag("Obs1")) 
        {
            Debug.Log("Ouch!!");
        } 
        else if (other.CompareTag("Key") && !keyCollisionRegistered) 
        {
            keyCollisionRegistered = true;
            lastCollisionTime = Time.time;

            keyCollisionCount++;
            Debug.Log("Key collided with: " + keyCollisionCount + " times");

            // Check if the key has been collided with 3 times
            if (keyCollisionCount == 3)
            {
                SceneManager.LoadScene(4); // Assuming scene index 4 is the desired level
            }
        } 
        else if (other.gameObject.CompareTag("Obs2")) 
        {
            Debug.Log("UnBlessed");
        } 
        else if (other.gameObject.CompareTag("Obs3")) 
        {
            Debug.Log("Watch Out!!");
        }
    }
}
