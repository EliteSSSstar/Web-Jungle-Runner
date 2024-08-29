using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public PowerupsEffect PowerupsEffect;

    private void OnTriggerEnter(Collider collision)
    {
        PowerupsEffect.Apply(collision.gameObject);
        Destroy(gameObject);
        

    }
    
}
