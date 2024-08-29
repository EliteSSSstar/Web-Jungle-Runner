using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class PowerupsEffect: ScriptableObject
{
    //Abstract method
    public abstract void Apply(GameObject target);
   
    
}
