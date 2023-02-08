using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    protected override void OnHit()
    {
        //Increase speed when hit
        MoveSpeed *= 2;
    }
    public void OnKill()
    {
        Invoke("OnChargerDeath", 0.0f);
    }
}
