using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected int PowerupDuration = 5;
    private Vector3 powerUpSpawn;
    private GameObject RF_Powerup;

    protected abstract void OnHit();

    private void PowerUpTimer()
    {
        
    }

}
