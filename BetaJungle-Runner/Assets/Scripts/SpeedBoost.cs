using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/SpeedBoost")]

public class SpeedBoost : PowerupsEffect
{
 
    public float amount = 5.0f;

    public override void Apply(GameObject target)
     {
          //find Speed of player apply speed from amount
           target.GetComponent<PlayerController>().speed += amount;
     }

}
