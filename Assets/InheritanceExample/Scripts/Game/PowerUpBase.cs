using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected int PowerupDuration = 5;
    private Vector3 powerUpSpawn;

    protected abstract void OnHit();
}
