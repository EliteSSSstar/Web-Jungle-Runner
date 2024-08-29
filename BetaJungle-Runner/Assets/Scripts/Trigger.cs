using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

   public ParticleSystem bomb;
   public ParticleSystem effect;
   public ParticleSystem slowEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            // Do something if collided with ground
        }
        else if (other.gameObject.CompareTag("BoostEffect"))
        {
            // Check if effect is not null before playing
            if (effect != null)
            {
                // Play particle effect if collided with obstacle
                effect.Play();
            }
        }

        else if (other.gameObject.CompareTag("SlowEffect"))
        {
            // Check if effect is not null before playing
            if (slowEffect != null)
            {
                // Play particle effect if collided with obstacle
                slowEffect.Play();
            }
        } 

        else if (other.gameObject.CompareTag("Obstacle"))
        {
            // Check if effect is not null before playing
            if (bomb != null)
            {
                // Play particle effect if collided with obstacle
                bomb.Play();
            }
        }

        
    }
}
