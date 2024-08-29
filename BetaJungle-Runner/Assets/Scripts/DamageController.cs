using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{

  [SerializeField] private int damageAmount;
   [SerializeField] private HearthSystem healthController;


    private void Start()
    {
        // Finding the HearthSystem component attached to the player
        healthController = GameObject.FindGameObjectWithTag("Player").GetComponent<HearthSystem>();
    }

   private void OnTriggerEnter(Collider collision)
   {
        if (collision.gameObject.CompareTag("Player"))
        {
            Damage();
            // gameObject.SetActive(false);
            if (gameObject != null)
            {
              Destroy(gameObject); // Optional, destroy game object on collision
            }
        }

   }

    public void Damage()
    {
        if (healthController != null)
        {
            // Apply damage to player's health
            healthController.playerHealth -= damageAmount;
            // Update health display
            healthController.UpdateHealth();
        }
        else
        {
            Debug.LogError("HearthSystem component not found on player!");
        }
    }

    


}
